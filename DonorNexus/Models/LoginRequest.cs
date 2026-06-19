using System;

namespace DonorNexus.Models
{
    public class LoginRequest
    {
        private string role;
        private string loginID;
        private string password;

        public string Role
        {
            get { return role; }

            set
            {
                if (value == "Admin" || value == "Donor")
                {
                    role = value;
                }
                else
                {
                    throw new Exception("Role must be Admin or Donor.");
                }
            }
        }

        public string LoginID
        {
            get { return loginID; }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    loginID = value;
                }
                else
                {
                    throw new Exception("Login ID cannot be empty.");
                }
            }
        }

        public string Password
        {
            get { return password; }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    password = value;
                }
                else
                {
                    throw new Exception("Password cannot be empty.");
                }
            }
        }

        public LoginRequest(
            string role,
            string loginID,
            string password)
        {
            Role = role;
            LoginID = loginID;
            Password = password;
        }
    }
}
