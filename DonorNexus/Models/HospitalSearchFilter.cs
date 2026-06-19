namespace DonorNexus.Models
{
    public class HospitalSearchFilter
    {
      

        private string city;

        private string district;

        private string bloodGroup;

      
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
                    throw new System.Exception("City cannot be empty.");
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
                    throw new System.Exception("District cannot be empty.");
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

                if (System.Array.Exists(validGroups,
                    group => group == value))
                {
                    bloodGroup = value;
                }
                else
                {
                    throw new System.Exception("Invalid Blood Group.");
                }
            }
        }

        public HospitalSearchFilter()
        {

        }

        public HospitalSearchFilter(
            string city,
            string district,
            string bloodGroup
            )
        {
            City = city;

            District = district;

            BloodGroup = bloodGroup;
        }
    }
}
