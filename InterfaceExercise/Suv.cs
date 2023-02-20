using System;
namespace InterfaceExercise
{
	public class Suv : IVehicle, ICompany
    {
		public Suv()
		{
		}
        //In each of your car, truck, and suv classes

        /*Create 2 members that are specific to each class
         * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
         *
         * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
         * 
         */
        public int CargoHoldSize { get; set; }
        public int PassengerAndTowingCapacity { get; set; }

        public int NumberOfWheels { get ; set ; }
        public int Year { get ; set; }
        public string Model { get; set ; }
        public int RowsOfSeats { get; set ; }

        public string Slogan { get ; set ; }
        public int Established { get ; set ; }
        public string CompanyName { get ; set ; }
        public string BiggestSeller { get ; set ; }

        public void PrintVehicle()
        {
            Console.WriteLine($"The {Year} {Model} was made by {CompanyName}, which was established in\n" +
                $"{Established}. Their slogan is {Slogan} and you may know them for their\n" +
                $"biggest seller, the {BiggestSeller}. The {Model} has {NumberOfWheels} wheels\n" +
                $"and {RowsOfSeats} rows of seats, along with a storage size of {CargoHoldSize}\n" +
                $"and weight capacity {PassengerAndTowingCapacity}.");
            Console.WriteLine();
        }
    }
}

