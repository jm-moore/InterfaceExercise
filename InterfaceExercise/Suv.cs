using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Suv : IVehicle, ICompany
    {
        public int CargoSize { get; set; }
        public bool MoreThan4Seats { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public bool AwdOr4wd  { get; set; }
        public bool Automatic { get; set; }
        public string companyName { get; set; }
        public string comapnyLogo { get; set; }

        public string Drive()
        {
            return "This suv is in drive.";
        }
    }
}
