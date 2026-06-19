using System;

namespace DonorNexus.Models
{
    public class SearchFilter
    {
       
        private string bloodGroup;
        private string city;
        private string district;

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

                if (Array.Exists(validGroups,
                    group => group == value))
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

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    city = value;
                }
                else
                {
                    throw new Exception("City cannot be empty.");
                }
            }
        }

        public string District
        {
            get { return district; }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    district = value;
                }
                else
                {
                    throw new Exception("District cannot be empty.");
                }
            }
        }


        public SearchFilter(
            string bloodGroup,
            string city,
            string district)
        {
            BloodGroup = bloodGroup;
            City = city;
            District = district;
        }

        public string GetSearchDetails()
        {
            return "Blood Group: " + BloodGroup +
                   "\nCity: " + City +
                   "\nDistrict: " + District;
        }
    }
}