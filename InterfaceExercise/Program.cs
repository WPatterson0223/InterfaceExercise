using System;
using System.Collections.Generic;
using System.Linq;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            Car car = new Car()
            {
                CompanyName = "Ford",
                Established = 1903,
                Slogan = "Go Further",
                BiggestSeller = "F-Series",
                NumberOfWheels = 4,
                Model = "Mustang",
                Year = 1965,
                RowsOfSeats = 2,
                PassengerCapacity = 100,
                TrunkSize = 200
            };
            Truck truck = new Truck()
            {
                CompanyName = "Chevrolet",
                Established = 1911,
                Slogan = "Find New Roads",
                BiggestSeller = "Silverado",
                NumberOfWheels = 4,
                Model = "S-10",
                Year = 1982,
                RowsOfSeats = 1,
                BedSize = 150,
                TowingCapacity = 500
            };
            Suv suv = new Suv()
            {
                CompanyName = "Lincoln",
                Established = 1917,
                Slogan = "What a luxury car should be",
                BiggestSeller = "Corsair",
                NumberOfWheels = 4,
                Model = "Navagator",
                Year = 1999,
                RowsOfSeats = 3,
                CargoHoldSize = 550,
                PassengerAndTowingCapacity = 1000
            };

            car.PrintVehicle();
            truck.PrintVehicle();
            suv.PrintVehicle();
        }
    }
}
