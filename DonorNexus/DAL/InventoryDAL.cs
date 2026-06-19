using DonorNexus.Models;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DonorNexus.DAL
{
    public class InventoryDAL
    {
        public void SaveInventory(BloodInventory inventory)
        {
            DatabaseHelper db =new DatabaseHelper();

            SqlConnection con = db.GetConnection();

            con.Open();

            string checkQuery =
                @"SELECT COUNT(*)
                  FROM BloodInventory
                  WHERE HospitalID = @HospitalID
                  AND BloodGroup = @BloodGroup";

            SqlCommand checkCmd = new SqlCommand(checkQuery, con);

            checkCmd.Parameters.AddWithValue(
                "@HospitalID",
                inventory.HospitalID);

            checkCmd.Parameters.AddWithValue(
                "@BloodGroup",
                inventory.BloodGroup);

            int count =
                Convert.ToInt32(
                    checkCmd.ExecuteScalar());

            if (count > 0)
            {
                string updateQuery =
                    @"UPDATE BloodInventory
                      SET UnitsAvailable = @Units
                      WHERE HospitalID = @HospitalID
                      AND BloodGroup = @BloodGroup";

                SqlCommand updateCmd =
                    new SqlCommand(updateQuery, con);

                updateCmd.Parameters.AddWithValue(
                    "@Units",
                    inventory.UnitsAvailable);

                updateCmd.Parameters.AddWithValue(
                    "@HospitalID",
                    inventory.HospitalID);

                updateCmd.Parameters.AddWithValue(
                    "@BloodGroup",
                    inventory.BloodGroup);

                updateCmd.ExecuteNonQuery();
            }
            else
            {
                string insertQuery =
                    @"INSERT INTO BloodInventory
                    (
                        HospitalID,
                        BloodGroup,
                        UnitsAvailable
                    )
                    VALUES
                    (
                        @HospitalID,
                        @BloodGroup,
                        @Units
                    )";

                SqlCommand insertCmd =new SqlCommand(insertQuery, con);

                insertCmd.Parameters.AddWithValue(
                    "@HospitalID",
                    inventory.HospitalID);

                insertCmd.Parameters.AddWithValue(
                    "@BloodGroup",
                    inventory.BloodGroup);

                insertCmd.Parameters.AddWithValue(
                    "@Units",
                    inventory.UnitsAvailable);

                insertCmd.ExecuteNonQuery();
            }

            con.Close();
        }

        public DataTable GetInventory()
        {
            DatabaseHelper db =new DatabaseHelper();

            SqlConnection con =db.GetConnection();

            string query =
                @"SELECT
                    H.HospitalName,
                    B.BloodGroup,
                    B.UnitsAvailable
                  FROM BloodInventory B
                  INNER JOIN Hospitals H
                  ON B.HospitalID = H.HospitalID";

            SqlDataAdapter adapter =new SqlDataAdapter(query, con);

            DataTable table =new DataTable();

            adapter.Fill(table);

            return table;
        }
    }
}
