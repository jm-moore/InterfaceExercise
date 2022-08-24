using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public bool AwdOr4wd { get; set; }
        public bool Automatic { get; set; }

        public string Drive();
    }
}
