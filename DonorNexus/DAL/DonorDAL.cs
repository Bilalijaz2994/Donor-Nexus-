using DonorNexus.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DonorNexus.DAL
{
    public class DonorDAL
    {
        public void RegisterDonor(Donor donor)
        {
            DatabaseHelper db = new DatabaseHelper();

            SqlConnection con =  db.GetConnection();

            con.Open();

            SqlCommand cmd =
                new SqlCommand("sp_RegisterDonor", con);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@FullName", donor.FullName.Trim());
            cmd.Parameters.AddWithValue("@CNIC", donor.CNIC.Trim());
            cmd.Parameters.AddWithValue("@PhoneNumber", donor.PhoneNumber.Trim());
            cmd.Parameters.AddWithValue("@Gender", donor.Gender.Trim());
            cmd.Parameters.AddWithValue("@Age", donor.Age);
            cmd.Parameters.AddWithValue("@Email", donor.Email.Trim());
            cmd.Parameters.AddWithValue("@Password", donor.Password);
            cmd.Parameters.AddWithValue("@BloodGroup", donor.BloodGroup.Trim());
            cmd.Parameters.AddWithValue("@City", donor.City.Trim());
            cmd.Parameters.AddWithValue("@District", donor.District.Trim());
            cmd.Parameters.AddWithValue("@GoogleMapLink", donor.GoogleMapLink);
            cmd.Parameters.AddWithValue("@IsAvailable", donor.IsAvailable);

            cmd.ExecuteNonQuery();

            con.Close();
        }

        public DataTable SearchDonors(SearchFilter filter)
        {
            DatabaseHelper db =
                new DatabaseHelper();

            SqlConnection con =
                db.GetConnection();

            string query =
                @"SELECT
                    FullName,
                    PhoneNumber,
                    BloodGroup,
                    City,
                    District
                  FROM Donors
                  WHERE UPPER(LTRIM(RTRIM(BloodGroup))) = UPPER(@BloodGroup)
                  AND UPPER(LTRIM(RTRIM(City))) = UPPER(@City)
                  AND UPPER(LTRIM(RTRIM(District))) = UPPER(@District)
                  AND IsAvailable = 1";

            SqlCommand cmd =
                new SqlCommand(query, con);

            cmd.Parameters.AddWithValue(
                "@BloodGroup",
                filter.BloodGroup.Trim());

            cmd.Parameters.AddWithValue(
                "@City",
                filter.City.Trim());

            cmd.Parameters.AddWithValue(
                "@District",
                filter.District.Trim());

            SqlDataAdapter adapter =
                new SqlDataAdapter(cmd);

            DataTable table =
                new DataTable();

            adapter.Fill(table);

            return table;
        }

        public int GetTotalDonors()
        {
            DatabaseHelper db =
                new DatabaseHelper();

            SqlConnection con =
                db.GetConnection();

            con.Open();

            string query =
                "SELECT COUNT(*) FROM Donors";

            SqlCommand cmd =
                new SqlCommand(query, con);

            int total =
                Convert.ToInt32(cmd.ExecuteScalar());

            con.Close();

            return total;
        }

        public DataTable GetAllDonors()
        {
            DatabaseHelper db =
                new DatabaseHelper();

            SqlConnection con =
                db.GetConnection();

            string query =
                @"SELECT
                    DonorID,
                    FullName,
                    PhoneNumber,
                    BloodGroup,
                    City,
                    District,
                    IsAvailable
                  FROM Donors";

            SqlDataAdapter adapter =
                new SqlDataAdapter(query, con);

            DataTable table =
                new DataTable();

            adapter.Fill(table);

            return table;
        }

        public DataTable GetDonorsForSelection()
        {
            DatabaseHelper db =
                new DatabaseHelper();

            SqlConnection con =
                db.GetConnection();

            string query =
                @"SELECT
                    DonorID,
                    FullName,
                    BloodGroup,
                    dbo.fn_IsEligibleForDonation(
                        DonorID,
                        CAST(GETDATE() AS DATE)) AS EligibilityStatus
                  FROM Donors
                  ORDER BY FullName";

            SqlDataAdapter adapter =
                new SqlDataAdapter(query, con);

            DataTable table =
                new DataTable();

            adapter.Fill(table);

            table.Columns.Add("DisplayText");

            foreach (DataRow row in table.Rows)
            {
                row["DisplayText"] =
                    row["FullName"].ToString() +
                    " - " +
                    row["BloodGroup"].ToString() +
                    " - " +
                    row["EligibilityStatus"].ToString();
            }

            return table;
        }

        public void DeleteDonor(int donorID)
        {
            DatabaseHelper db =
                new DatabaseHelper();

            SqlConnection con =
                db.GetConnection();

            con.Open();

            string query =
                @"DELETE FROM Donors
                  WHERE DonorID = @DonorID";

            SqlCommand cmd =
                new SqlCommand(query, con);

            cmd.Parameters.AddWithValue(
                "@DonorID",
                donorID);

            cmd.ExecuteNonQuery();

            con.Close();
        }

        public Donor GetDonorById(int donorID)
        {
            DatabaseHelper db =new DatabaseHelper();

            SqlConnection con = db.GetConnection();

            con.Open();

            string query =
                @"SELECT *,
                    dbo.fn_GetDonorTotalDonations(@DonorID) AS TotalDonationCount
                  FROM Donors
                  WHERE DonorID = @DonorID";

            SqlCommand cmd =
                new SqlCommand(query, con);

            cmd.Parameters.AddWithValue(
                "@DonorID",
                donorID);

            SqlDataReader reader =
                cmd.ExecuteReader();

            Donor donor = null;

            if (reader.Read())
            {
                donor =
                    new Donor();

                donor.DonorID = donorID;
                donor.FullName = reader["FullName"].ToString();
                donor.CNIC = reader["CNIC"].ToString();
                donor.PhoneNumber = reader["PhoneNumber"].ToString();
                donor.Gender = reader["Gender"].ToString();
                donor.Age = Convert.ToInt32(reader["Age"]);
                donor.Email = reader["Email"].ToString();
                donor.Password = reader["Password"].ToString();
                donor.BloodGroup = reader["BloodGroup"].ToString();
                donor.City = reader["City"].ToString();
                donor.District = reader["District"].ToString();
                donor.GoogleMapLink = reader["GoogleMapLink"].ToString();
                donor.IsAvailable = Convert.ToBoolean(reader["IsAvailable"]);
                donor.TotalDonations = Convert.ToInt32(reader["TotalDonationCount"]);
            }

            con.Close();

            return donor;
        }

        public void UpdateAvailability(int donorID, bool status)
        {
            DatabaseHelper db =
                new DatabaseHelper();

            SqlConnection con =
                db.GetConnection();

            con.Open();

            string query =
                @"UPDATE Donors
                  SET IsAvailable = @Status
                  WHERE DonorID = @DonorID";

            SqlCommand cmd =
                new SqlCommand(query, con);

            cmd.Parameters.AddWithValue(
                "@Status",
                status);

            cmd.Parameters.AddWithValue(
                "@DonorID",
                donorID);

            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}
