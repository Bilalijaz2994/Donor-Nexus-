using System;

namespace DonorNexus.Models
{
    public class DonationRecord
    {
       
        private int donationID;
        private int donorID;
        private int hospitalID;
        private DateTime donationDate;
        private int unitsDonated;
    

        public int DonationID
        {
            get { return donationID; }

            set
            {
                donationID = value;
            }
        }

        public int DonorID
        {
            get { return donorID; }

            set
            {
                if (value > 0)
                {
                    donorID = value;
                }
                else
                {
                    throw new Exception("Invalid Donor ID.");
                }
            }
        }

      
        public int HospitalID
        {
            get { return hospitalID; }

            set
            {
                if (value > 0)
                {
                    hospitalID = value;
                }
                else
                {
                    throw new Exception( "Invalid Hospital ID.");
                }
            }
        }

        public DateTime DonationDate
        {
            get { return donationDate; }

            set
            {
                if (value <= DateTime.Now)
                {
                    donationDate = value;
                }
                else
                {
                    throw new Exception( "Donation date cannot be in the future.");
                }
            }
        }

        public int UnitsDonated
        {
            get { return unitsDonated; }

            set
            {
                if (value > 0)
                {
                    unitsDonated = value;
                }
                else
                {
                    throw new Exception(
                        "Units donated must be greater than zero.");
                }
            }
        }

        public DonationRecord( int donationID, int donorID,int hospitalID,DateTime donationDate, int unitsDonated )
        {
            DonationID = donationID;

            DonorID = donorID;

            HospitalID = hospitalID;

            DonationDate = donationDate;

            UnitsDonated = unitsDonated;
        }

        public virtual string GetDonationDetails()
        {
            return
                "Donation ID: " + DonationID +
                "\nDonor ID: " + DonorID +
                "\nHospital ID: " + HospitalID +
                "\nDonation Date: " +
                DonationDate.ToShortDateString() +
                "\nUnits Donated: " +
                UnitsDonated;
        }
    }
}