using System;
namespace DonorNexus.Models
{
    public class Admin
    {

        private int adminID;
        private string adminName;
        private string password;

        public int AdminID
        {
            get { return adminID; }
            set { adminID = value; }
        }

        public string AdminName
        {
            get { return adminName; }
            set { adminName = value; }
        }

        public string Password
        {
            get { return password; }

            set
            {
                if (value.Length >= 6)
                {
                    password = value;
                }
                else
                {
                    throw new Exception(
                        "Password must be at least 6 characters.");
                }
            }
        }

        public Admin(int adminID,string adminName,string password)
        {   AdminID = adminID;
            AdminName = adminName;
            Password = password;
        }

        public string GetAdminDetails()
        {
            return "Admin ID: " + AdminID +
                   "\nAdmin Name: " + AdminName;
        }
    }
}
