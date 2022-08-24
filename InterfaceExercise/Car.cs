using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Car : ICompany, IVehicle
    {
        public int TrunkSize { get; set; }

        public bool HasLeatherSeats { get; set; }
        public string companyName { get; set; }
        public string comapnyLogo { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public bool AwdOr4wd { get; set; }
        public bool Automatic { get; set; }

        public string Drive()
        {
            return "This car is in drive.";
        }
    }
}
