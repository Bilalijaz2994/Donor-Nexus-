using DonorNexus.Models;
using System.Data;
using System.Data.SqlClient;

namespace DonorNexus.DAL
{
    public class HospitalDAL
    {
        public void AddHospital(Hospital hospital)
        {
            DatabaseHelper db = new DatabaseHelper();

            SqlConnection con = db.GetConnection();

            con.Open();

            string query =
                @"INSERT INTO Hospitals
                (
                    HospitalName,
                    City,
                    District,
                    PhoneNumber
                )
                VALUES
                (
                    @HospitalName,
                    @City,
                    @District,
                    @PhoneNumber
                )";

            SqlCommand cmd =
                new SqlCommand(query, con);

            cmd.Parameters.AddWithValue(
                "@HospitalName",
                hospital.HospitalName.Trim());

            cmd.Parameters.AddWithValue(
                "@City",
                hospital.City.Trim());

            cmd.Parameters.AddWithValue(
                "@District",
                hospital.District.Trim());

            cmd.Parameters.AddWithValue(
                "@PhoneNumber",
                hospital.PhoneNumber.Trim());

            cmd.ExecuteNonQuery();

            con.Close();
        }

        public DataTable GetHospitals()
        {
            DatabaseHelper db =new DatabaseHelper();

            SqlConnection con =db.GetConnection();

            string query =
                @"SELECT HospitalID,
                         HospitalName
                  FROM Hospitals";

            SqlDataAdapter adapter =
                new SqlDataAdapter(query, con);

            DataTable table =
                new DataTable();

            adapter.Fill(table);

            return table;
        }

        public DataTable SearchHospitals(HospitalSearchFilter filter)
        {
            DatabaseHelper db = new DatabaseHelper();

            SqlConnection con = db.GetConnection();

            string query =
                @"SELECT
                    H.HospitalName,
                    H.City,
                    H.District,
                    H.PhoneNumber,
                    B.BloodGroup,
                    B.UnitsAvailable
                  FROM Hospitals H
                  INNER JOIN BloodInventory B
                  ON H.HospitalID = B.HospitalID
                  WHERE UPPER(LTRIM(RTRIM(H.City))) = UPPER(@City)
                  AND UPPER(LTRIM(RTRIM(H.District))) = UPPER(@District)
                  AND UPPER(LTRIM(RTRIM(B.BloodGroup))) = UPPER(@BloodGroup)
                  AND B.UnitsAvailable > 0
                  ORDER BY H.HospitalName,
                           B.BloodGroup";

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue(
                "@City",
                filter.City.Trim());

            cmd.Parameters.AddWithValue(
                "@District",
                filter.District.Trim());

            cmd.Parameters.AddWithValue(
                "@BloodGroup",
                filter.BloodGroup.Trim());

            SqlDataAdapter adapter =  new SqlDataAdapter(cmd);

            DataTable table =new DataTable();

            adapter.Fill(table);

            return table;
        }

        public void DeleteHospital(int hospitalID)
        {
            DatabaseHelper db = new DatabaseHelper();

            SqlConnection con =db.GetConnection();

            con.Open();

            string deleteInventoryQuery =
                @"DELETE FROM BloodInventory
                  WHERE HospitalID = @HospitalID";

            SqlCommand deleteInventoryCmd = new SqlCommand(deleteInventoryQuery, con);

            deleteInventoryCmd.Parameters.AddWithValue(
                "@HospitalID",
                hospitalID);

            deleteInventoryCmd.ExecuteNonQuery();

            string deleteHospitalQuery =
                @"DELETE FROM Hospitals
                  WHERE HospitalID = @HospitalID";

            SqlCommand deleteHospitalCmd = new SqlCommand(deleteHospitalQuery, con);

            deleteHospitalCmd.Parameters.AddWithValue(
                "@HospitalID",
                hospitalID);

            deleteHospitalCmd.ExecuteNonQuery();

            con.Close();
        }
    }
}
