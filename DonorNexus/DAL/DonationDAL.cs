using DonorNexus.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DonorNexus.DAL
{
    public class DonationDAL
    {
        public void AddDonation(DonationRecord record)
        {
            DatabaseHelper db = new DatabaseHelper();

            SqlConnection con = db.GetConnection();

            con.Open();

            try
            {
                SqlCommand cmd =
                    new SqlCommand("sp_RecordDonation", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue(
                    "@DonorID",
                    record.DonorID);

                cmd.Parameters.AddWithValue(
                    "@HospitalID",
                    record.HospitalID);

                cmd.Parameters.AddWithValue(
                    "@DonationDate",
                    record.DonationDate);

                cmd.Parameters.AddWithValue(
                    "@UnitsDonated",
                    record.UnitsDonated);

                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        public string GetDonationEligibility(
            int donorID,
            DateTime donationDate)
        {
            DatabaseHelper db =
                new DatabaseHelper();

            SqlConnection con =
                db.GetConnection();

            con.Open();

            string query =
                @"SELECT dbo.fn_IsEligibleForDonation(
                    @DonorID,
                    @DonationDate)";

            SqlCommand cmd =
                new SqlCommand(query, con);

            cmd.Parameters.AddWithValue(
                "@DonorID",
                donorID);

            cmd.Parameters.AddWithValue(
                "@DonationDate",
                donationDate.Date);

            string eligibility =
                cmd.ExecuteScalar().ToString();

            con.Close();

            return eligibility;
        }

        public DataTable GetDonationHistory(int donorID)
        {
            DatabaseHelper db =new DatabaseHelper();

            SqlConnection con = db.GetConnection();

            con.Open();

            bool hasHospitalID =
                DonationRecordsHasHospitalID(
                    con,
                    null);

            con.Close();

            string query;

            if (hasHospitalID)
            {
                query =
                    @"SELECT
                        D.DonationDate,
                        H.HospitalName,
                        D.UnitsDonated
                      FROM DonationRecords D
                      INNER JOIN Hospitals H
                      ON D.HospitalID = H.HospitalID
                      WHERE D.DonorID = @DonorID
                      ORDER BY D.DonationDate DESC";
            }
            else
            {
                query =
                    @"SELECT
                        DonationDate,
                        HospitalName,
                        UnitsDonated
                      FROM DonationRecords
                      WHERE DonorID = @DonorID
                      ORDER BY DonationDate DESC";
            }

            SqlCommand cmd =  new SqlCommand(query, con);

            cmd.Parameters.AddWithValue(
                "@DonorID",
                donorID);

            SqlDataAdapter adapter =  new SqlDataAdapter(cmd);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        private bool DonationRecordsHasHospitalID(
            SqlConnection con,
            SqlTransaction transaction)
        {
            string query =
                @"SELECT COL_LENGTH(
                    'DonationRecords',
                    'HospitalID')";

            SqlCommand cmd =
                new SqlCommand(
                    query,
                    con,
                    transaction);

            object result =
                cmd.ExecuteScalar();

            return result != DBNull.Value &&
                result != null;
        }

        private string GetHospitalName(
            SqlConnection con,
            SqlTransaction transaction,
            int hospitalID)
        {
            string query =
                @"SELECT HospitalName
                  FROM Hospitals
                  WHERE HospitalID = @HospitalID";

            SqlCommand cmd =
                new SqlCommand(
                    query,
                    con,
                    transaction);

            cmd.Parameters.AddWithValue(
                "@HospitalID",
                hospitalID);

            object result =
                cmd.ExecuteScalar();

            if (result == null)
            {
                throw new Exception("Selected hospital was not found.");
            }

            return result.ToString();
        }
    }
}
