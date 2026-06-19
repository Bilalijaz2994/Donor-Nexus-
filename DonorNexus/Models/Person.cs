using System;
using System.IO;
using System.Linq;

namespace DonorNexus.Models
{

    public abstract class Person
    {
       
        private string cnic;
        private string fullName;
        private string phoneNumber;
        private string gender;
        private int age;
        public string CNIC
        {
            get { return cnic;}

            set
            {
                if (value.Length == 13 && value.All(char.IsDigit))
                {
                    cnic=value;
                }
                else
                {
                    throw new Exception("CNIC must contain exactly 13 digits.");
                }
            }
        }

      
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

   
        public string PhoneNumber
        {
            get {return phoneNumber;}

            set
            {
              
                if (value.Length == 11 && value.StartsWith("03") && value.All(char.IsDigit))
                {
                    phoneNumber = value;
                }
                else
                {
                    throw new Exception("Phone number must start with 03 and contain 11 digits.");
                }
            }
        }

 
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public int Age
        {
            get {return age;}

            set
            {
                if (value >= 18 && value <= 65)
                {
                   age = value;
                }
                else
                {
                    throw new Exception("Age must be between 18 and 65.");
                }
            }
        }

        public Person()
        {
        }


        public Person(string cnic,string fullName,string phoneNumber,string gender,int age)
        {
           CNIC = cnic;
            FullName = fullName;
            PhoneNumber = phoneNumber;
            Gender = gender;
            Age = age;
        }

        public abstract string GetDetails();
    }
}