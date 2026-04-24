using System;
using System.Collections.Generic;
using System.Text;

namespace HomeAffairsDigitalIdentityProcessor
{
    internal class CitizenProfile
    {
        // Properties
        public string FullName { get; set; }
        public string IDNumber { get; set; }
        public int Age { get; set; }
        public string CitizenshipStatus { get; set; }

        // Constructor
        public CitizenProfile(string fullName, string idNumber, string citizenshipStatus)
        {
            FullName = fullName;
            IDNumber = idNumber;
            CitizenshipStatus = citizenshipStatus;
            Age = CalculateAge(); 
        }

        // Extracts birth date from ID and calculates user age
        private int CalculateAge()
        {
            if (IDNumber.Length < 6)
                return 0;

            int year = int.Parse(IDNumber.Substring(0, 2));
            int month = int.Parse(IDNumber.Substring(2, 2));
            int day = int.Parse(IDNumber.Substring(4, 2));

            // Determine century (1900s or 2000s)
            int currentYear = DateTime.Now.Year % 100;
            int fullYear = year <= currentYear ? 2000 + year : 1900 + year;

            DateTime birthDate = new DateTime(fullYear, month, day);
            DateTime today = DateTime.Today;

            int age = today.Year - birthDate.Year;

            // Adjust if birthday hasn't occurred yet this year
            if (birthDate > today.AddYears(-age))
                age--;

            return age;
        }

        // Validates the ID number
        public string ValidateID()
        {
            if (IDNumber.Length != 13)
                return "Invalid: ID number must be exactly 13 digits.";

            if (!IDNumber.All(char.IsDigit))
                return "Invalid: ID number must contain digits only.";

            if (Age < 0 || Age > 130)
                return "Invalid: Age extracted from ID is not realistic.";

            return "Valid: ID number is valid.";
        }
    }
}
