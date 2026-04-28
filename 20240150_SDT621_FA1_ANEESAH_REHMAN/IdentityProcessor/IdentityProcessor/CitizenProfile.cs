using System;
using System.Collections.Generic;
using System.Text;

namespace IdentityProcessor
{
    public class CitizenProfile
    {
        public string FullName { get; set; }
        public string IDNumber { get; set; }
        public string CitizenshipStatus { get; set; }
        public int Age { get; set; }

        public CitizenProfile(string name, string id, string citizenship)
        {
            FullName = name;
            IDNumber = id;
            CitizenshipStatus = citizenship;
            Age = CalculateAge();
        }

        private int CalculateAge()
        {
            try
            {
                // Prevent crash first
                if (IDNumber.Length != 13)
                    return -1;

                if (!long.TryParse(IDNumber, out _))
                    return -1;

                string yy = IDNumber.Substring(0, 2);
                string mm = IDNumber.Substring(2, 2);
                string dd = IDNumber.Substring(4, 2);

                int year = int.Parse(yy);

                if (year <= DateTime.Now.Year % 100)
                    year += 2000;
                else
                    year += 1900;

                DateTime birthDate = new DateTime(year, int.Parse(mm), int.Parse(dd));

                int age = DateTime.Now.Year - birthDate.Year;

                if (DateTime.Now < birthDate.AddYears(age))
                    age--;

                return age;
            }
            catch
            {
                return -1;
            }
        }

        public string ValidateID()
        {
            if (IDNumber.Length != 13)
                return "Invalid ID: Must be 13 digits.";

            if (!long.TryParse(IDNumber, out _))
                return "Invalid ID: Must contain only numbers.";

            if (Age < 0)
                return "Invalid ID: Cannot calculate age.";

            return "Valid ID. Citizen is " + Age + " years old.";
        }
    }
}