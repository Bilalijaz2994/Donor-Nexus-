using System;

namespace DonorNexus.Models
{
    public class BloodInventory
    {

        private int inventoryID;

        private int hospitalID;

        private string bloodGroup;

        private int unitsAvailable;

        public int InventoryID
        {
            get { return inventoryID; }

            set { inventoryID = value; }
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
            }
        }

        public string BloodGroup
        {
            get { return bloodGroup; }

            set
            {

                if (value == "A+" || value == "A-" || value == "B+" ||value == "B-" ||value == "AB+" ||value == "AB-" ||
                value == "O+" ||value == "O-" )
                {
                    bloodGroup = value;
                }
            }
        }

        public int UnitsAvailable
        {
            get { return unitsAvailable; }

            set
            {

                if (value >= 0)
                {
                    unitsAvailable = value;
                }
            }
        }

        public BloodInventory(int inventoryID, int hospitalID,string bloodGroup, int unitsAvailable
            )
        {
            InventoryID = inventoryID;

            HospitalID = hospitalID;

            BloodGroup = bloodGroup;

            UnitsAvailable = unitsAvailable;
        }

        public virtual string GetInventoryDetails()
        {
            return
                "Inventory ID: " + InventoryID +
                "\nHospital ID: " + HospitalID +
                "\nBlood Group: " + BloodGroup +
                "\nUnits Available: " + UnitsAvailable;
        }
    }
}