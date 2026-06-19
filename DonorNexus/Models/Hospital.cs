using System;

namespace DonorNexus.Models
{
    public class Hospital
    {

        private int hospitalID;

        private string hospitalName;

        private string city;

        private string district;

        private string phoneNumber;

        public int HospitalID
        {
            get { return hospitalID; }

            set { hospitalID = value; }
        }

        public string HospitalName
        {
            get { return hospitalName; }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    hospitalName = value;
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
            }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }

            set
            {
              

                if (
                    value.Length == 11 &&
                    value.StartsWith("03")
                   )
                {
                    phoneNumber = value;
                }
            }
        }

        public Hospital(
            int hospitalID,
            string hospitalName,
            string city,
            string district,
            string phoneNumber
            )
        {
            HospitalID = hospitalID;

            HospitalName = hospitalName;

            City = city;

            District = district;

            PhoneNumber = phoneNumber;
        }

        public virtual string GetHospitalDetails()
        {
            return
                "Hospital ID: " + HospitalID +
                "\nHospital Name: " + HospitalName +
                "\nCity: " + City +
                "\nDistrict: " + District +
                "\nPhone Number: " + PhoneNumber;
        }
    }
}