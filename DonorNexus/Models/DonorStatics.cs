using System;

namespace DonorNexus.Models
{
    public class DonorStatistics
    {
       

        private int totalRegisteredDonors;

        public int TotalRegisteredDonors
        {
            get { return totalRegisteredDonors; }
            set { totalRegisteredDonors = value; }
        }

        public DonorStatistics(int totalRegisteredDonors)
        {
            TotalRegisteredDonors = totalRegisteredDonors;
        }

        public string GetStatistics()
        {
            return "Total Registered Donors: " + TotalRegisteredDonors;
        }
    }
}