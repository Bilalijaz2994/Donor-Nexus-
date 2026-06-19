using DonorNexus.Models;
using System;
using System.Data.SqlClient;

namespace DonorNexus.DAL
{
    public class AuthDAL
    {
        public LoginResult Login(LoginRequest request)
        {
            DatabaseHelper db = new DatabaseHelper();

            SqlConnection con = db.GetConnection();

            con.Open();

            string query = "";

            if (request.Role == "Donor")
            {
                query =
                    @"SELECT DonorID
                      FROM Donors
                      WHERE Email = @LoginID
                      AND Password = @Password";
            }
            else if (request.Role == "Admin")
            {
                query =
                    @"SELECT AdminID
                      FROM Admins
                      WHERE AdminName = @LoginID
                      AND Password = @Password";
            }

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue(
                "@LoginID",
                request.LoginID.Trim());

            cmd.Parameters.AddWithValue(
                "@Password",
                request.Password);

            SqlDataReader reader =
                cmd.ExecuteReader();

            LoginResult result =
                new LoginResult(false, 0, request.Role);

            if (reader.Read())
            {
                int donorID = 0;

                if (request.Role == "Donor")
                {
                    donorID =
                        Convert.ToInt32(reader["DonorID"]);
                }

                result =
                    new LoginResult(true, donorID, request.Role);
            }

            con.Close();

            return result;
        }
    }
}
