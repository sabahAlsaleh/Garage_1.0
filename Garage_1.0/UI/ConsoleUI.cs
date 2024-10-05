using Garage_1._0.vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_1._0.UI
{
    public class ConsoleUI : IUserInterface
    {
        private GarageHandler garageHandler;

        public ConsoleUI(GarageHandler handler)
        {
            this.garageHandler = handler;
        }

        public void DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine("\n --- Garage Menu ---");
                Console.WriteLine (" 1. List all vehicles" );
                Console.WriteLine (" 2. List vehicle types and counts" );
                Console.WriteLine(" 3. Add a vehicle");
                Console.WriteLine (" 4. Remove a vehicle");
                Console.WriteLine(" 5. Search vehicles ");
                Console.WriteLine (" 6. Create a new garage") ;
                Console.WriteLine(" 0. Exit ");  
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ListAllVehicles();
                        break;

                    case "2":
                         ListVehicleTypesAndCounts();
                        break ;

                    case "3":
                         AddVehicle();
                        break;
                    case "4":
                         RemoveVehicle();
                        break;
                         
                    case "5":
                         SearchVehicle();
                        break;

                    case "6":
                        CreateNewGarage();
                        break;

                    case "0":
                        return;  // Exits the application
                    default:
                         Console.WriteLine ("mInvalid choice, please try again. ");
                        break;
                }
            }
        }
        public void ListAllVehicles()
        {
            var vehicles = garageHandler.ListAllVehicles();
            if (!vehicles.Any())
                Console.WriteLine("The garage is empty.");
            else
            {
                foreach (var v in vehicles)
                {
                    Console.WriteLine(v);

                }
            }

        }

    
        // List the types of vehicles and their counts
        public void ListVehicleTypesAndCounts()
        {
            var vehicles = garageHandler.GetVehicleTypesAndCounts();
            foreach (var v in vehicles)
            {
                Console.WriteLine($" {v.Key}: {v.Value}" );
            }
        }

        // Add a vehicle to the garage
        public void AddVehicle()
        {
            Console.WriteLine("Enter vehicle type (Car, Motorcycle, Airplane, Bus.): ");
            string type = Console.ReadLine();

            Console.WriteLine("Enter registration number: ");
            string regNumber = Console.ReadLine();

            Console.WriteLine("Enter color: ");
             string color = Console.ReadLine();

            Console.WriteLine("Enter number of wheels: ");
            int wheels = int.Parse(Console.ReadLine());

            Vehicle vehicle = null;

            // Create a new vehicle based on the user's input
            switch (type.ToLower())
            {
                case "car":
                    Console.WriteLine("Enter fuel type  (Gasoline/ Diesel / EL): ");
                    string fuelType = Console.ReadLine()           ;
                    vehicle = new Car(regNumber , color, wheels , fuelType);
                    break;

                case "motorcycle":
                    Console.WriteLine("Enter cylinder volume: ");
                    int cylinderVolume = int.Parse(Console.ReadLine());
                    vehicle = new Motorcycle(regNumber, color, wheels, cylinderVolume);
                    break;
                case "bus":
                    Console.WriteLine("Enter number of seats: ");
                     int numberOfSeats = int.Parse(Console.ReadLine() );
                    vehicle = new Bus(regNumber, color , wheels , numberOfSeats);
                    break;

                case "airplane":
                    Console.WriteLine("Enter number of engines: ");
                    int numberOfEngines = int.Parse(Console.ReadLine() );
                    vehicle = new Airplane(regNumber, color, wheels, numberOfEngines);
                    break;

                default:
                    Console.WriteLine("  Unsupported vehicle type.");
                    return;
            }


            // Try to park the vehicle
            garageHandler.ParkVehicle(vehicle);

        }

        // Remove a vehicle from the garage
        public void RemoveVehicle()
        {
            Console.WriteLine("Enter registration number of vehicle to remove: ");
            string regNumber = Console.ReadLine();

            garageHandler.RemoveVehicle(regNumber);
        }

        // Search for vehicles by color and number of wheels
        public void SearchVehicle()
        {
            Console.WriteLine( "Enter color to search for: " );
            string color = Console.ReadLine();

            Console.WriteLine ( "Enter number of wheels to search for: " );
            int wheels = int.Parse(Console.ReadLine());

            var vehicles = garageHandler.SearchVehicles(color, wheels);
            if (!vehicles.Any())  Console.WriteLine("No vehicles found with the given criteria.");
            else
            {
                foreach (var vehicle in vehicles)
                {
                    Console.WriteLine(vehicle);
                }
            }
        }

        // Create a new garage with a specified capacity
        public void CreateNewGarage()
        {
            Console.WriteLine("Enter garage capacity: ");
            int capacity = int.Parse(Console.ReadLine() );

            garageHandler.CreateNewGarage(capacity);
        }
    }
}
