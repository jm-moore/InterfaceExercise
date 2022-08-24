using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces DONE

            //Create 2 Interfaces called IVehicle & ICompany DONE

            //Create 3 classes called Car , Truck , & SUV DONE

            //In your IVehicle DONE

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany DONE

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class DONE
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members. DONE
             * 
             */

            List<IVehicle> vehicles = new List<IVehicle>();

            var mustang = new Car();
            mustang.Automatic = true;
            mustang.companyName = "Ford";
            mustang.Year = 2015;
            mustang.HasLeatherSeats = true;
            mustang.TrunkSize = 12;
            mustang.AwdOr4wd = false;
            mustang.comapnyLogo = "blue oval shape with ford centered and written in white";
            mustang.Model = "Mustang";
            mustang.Drive();

            vehicles.Add(mustang);

            var tahoe = new Suv();
            tahoe.comapnyLogo = "the chevorlet bowtie";
            tahoe.Automatic = true;
            tahoe.AwdOr4wd = true;
            tahoe.MoreThan4Seats = true;
            tahoe.CargoSize = 75;
            tahoe.companyName = "Chevorlet";
            tahoe.Model = "Tahoe";
            tahoe.Year = 2020;
            tahoe.Drive();

            vehicles.Add(tahoe);

            var frontier = new Truck();
            frontier.Automatic = true;
            frontier.WorkOrPersonal = "Personal";
            frontier.AwdOr4wd = true;
            frontier.BedSize = 70;
            frontier.comapnyLogo = "silver circle with nissan written in the middle";
            frontier.Year = 2022;
            frontier.companyName = "Nissan";
            frontier.Model = "Frontier";
            frontier.Drive();

            vehicles.Add(frontier);

            foreach (var item in vehicles)
            {
                Console.WriteLine($"Model: {item.Model}     Year: {item.Year}      Automatic: {item.Automatic}      AWD or 4WD: {item.AwdOr4wd}");
                Console.WriteLine(item.Drive());
                Console.WriteLine();
            }
            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
        }
    }
}
