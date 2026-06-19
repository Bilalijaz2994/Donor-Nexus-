using System;
namespace DonorNexus.Models
{
    public class Donor : Person
    {
        private int donorID;
        private string email;
        private string password;
        private string bloodGroup;
        private string city;
        private string district;
        private string googleMapLink;

        private bool isAvailable;
        private int totalDonations;


        public int DonorID
        {
            get { return donorID; }
            set { donorID = value; }
        }

        public string Email
        {
            get { return email; }

            set
            {
                if (value.Contains("@") && value.Contains(".com"))
                {
                    email = value;
                }
                else
                {
                    throw new Exception("Invalid Email Address.");
                }
            }
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
                    throw new Exception("Password must be at least 6 characters.");
                }
            }
        }
        public string BloodGroup
        {
            get { return bloodGroup; }

            set
            {
                string[] validGroups =
                {
                    "A+","A-",
                    "B+","B-",
                    "AB+","AB-",
                    "O+","O-"
                };

                if (Array.Exists(validGroups, group => group == value))
                {
                    bloodGroup = value;
                }
                else
                {
                    throw new Exception("Invalid Blood Group.");
                }
            }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string District
        {
            get { return district; }
            set { district = value; }
        }

        public string GoogleMapLink
        {
            get { return googleMapLink; }
            set { googleMapLink = value; }
        }

        public bool IsAvailable
        {
            get { return isAvailable; }
            set { isAvailable = value; }
        }

        public int TotalDonations
        {
            get { return totalDonations; }

            set
            {
                if (value >= 0)
                {
                    totalDonations = value;
                }
                else
                {
                    throw new Exception("Total Donations cannot be negative.");
                }
            }
        }

          public Donor()
          {
          }


        public Donor(int donorID,string cnic,string fullName,string phoneNumber,string gender,int age, string email,string password,string bloodGroup,
         string city, string district, string googleMapLink): base(cnic, fullName, phoneNumber, gender, age)
        {
            DonorID = donorID;
            Email = email;
            Password = password;
            BloodGroup = bloodGroup;
            City = city;
            District = district;
            GoogleMapLink = googleMapLink;

           
            IsAvailable = true;
            TotalDonations = 0;
        }

        public override string GetDetails()
        {
            return "Donor ID: " + DonorID +
                   "\nName: " + FullName +
                   "\nCNIC: " + CNIC +
                   "\nPhone Number: " + PhoneNumber +
                   "\nGender: " + Gender +
                   "\nAge: " + Age +
                   "\nEmail: " + Email +
                   "\nBlood Group: " + BloodGroup +
                   "\nCity: " + City +
                   "\nDistrict: " + District +
                   "\nAvailable: " + IsAvailable +
                   "\nTotal Donations: " + TotalDonations;
        }
    }
}
