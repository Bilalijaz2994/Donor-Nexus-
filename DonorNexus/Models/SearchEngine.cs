using System;
using System.Collections.Generic;

namespace DonorNexus.Models
{
    public class SearchEngine
    {
    

        public List<Donor> SearchDonors(
            List<Donor> donors,
            SearchFilter filter)
        {
      

            List<Donor> matchedDonors =
                new List<Donor>();


            foreach (Donor donor in donors)
            {

                if (
                    donor.BloodGroup == filter.BloodGroup &&
                    donor.City.ToLower() == filter.City.ToLower() &&
                    donor.District.ToLower() == filter.District.ToLower() &&
                    donor.IsAvailable == true
                   )
                {
                    matchedDonors.Add(donor);
                }
            }

            return matchedDonors;
        }

        public List<Hospital> SearchHospitals(
            List<Hospital> hospitals,
            HospitalSearchFilter filter)
        {
            List<Hospital> matchedHospitals =
                new List<Hospital>();

            foreach (Hospital hospital in hospitals)
            {
                if (
                    hospital.City.ToLower() == filter.City.ToLower() &&
                    hospital.District.ToLower() == filter.District.ToLower()
                   )
                {
                    matchedHospitals.Add(hospital);
                }
            }

            return matchedHospitals;
        }
    }
}
