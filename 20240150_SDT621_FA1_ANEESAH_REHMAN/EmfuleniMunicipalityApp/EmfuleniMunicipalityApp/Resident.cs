using System;
using System.Collections.Generic;
using System.Text;

namespace EmfuleniMunicipalityApp
{
    public class Resident
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string AccountNumber { get; set; }
        public double MonthlyUsage { get; set; }

        public Resident(string name, string address, string accountNumber, double monthlyUsage)
        {
            Name = name;
            Address = address;
            AccountNumber = accountNumber;
            MonthlyUsage = monthlyUsage;
        }

        public void DisplayResident()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Account No: " + AccountNumber);
            Console.WriteLine("Monthly Utility Usage(kWh or literes): " + MonthlyUsage);
        }
    }
}