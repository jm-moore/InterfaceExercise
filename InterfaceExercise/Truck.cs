using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Truck : ICompany, IVehicle
    {
        public int BedSize { get; set; }
        public string WorkOrPersonal { get; set; }
        public string companyName { get; set; }
        public string comapnyLogo { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public bool AwdOr4wd { get; set; }
        public bool Automatic { get; set; }

        public string Drive()
        {
            return "This truck is in drive.";
        }
    }
}
