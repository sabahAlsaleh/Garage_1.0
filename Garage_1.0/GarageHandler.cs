using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Garage_1._0.vehicle;

namespace Garage_1._0
{
    public class GarageHandler : IHandler
    {
        private Garage<Vehicle> garage;

        public GarageHandler(int capacity)
        {
            garage = new Garage<Vehicle>(capacity);
        }

        // park a vehicle in the garage 
        public void ParkVehicle(Vehicle vehicle)
        {

            if (garage.Park(vehicle) )  Console.WriteLine("Vehicle parked successfully .");
            else Console.WriteLine(" Garage is full.");
        }

            //remove a vehicle based on the registration number
        public void RemoveVehicle(string registrationNumber)
        {
            if (garage.Remove(registrationNumber))
                Console.WriteLine(" Vehicle removed successfully.");
            else
                Console.WriteLine("Vehicle not found.");
        }

           // list all vehicles in the garage
        public IEnumerable<Vehicle> ListAllVehicles()
        {
            return garage;
        }

          // Method to list vehicle types and their counts
        public Dictionary<string, int> GetVehicleTypesAndCounts()
        {


            return garage.GroupBy(v => v.GetType().Name)
                         .ToDictionary(g => g.Key, g => g.Count());

           
        }

        //search for vehicles based on color and number of wheels
        public IEnumerable<Vehicle> SearchVehicles(string color, int wheels)
        {


            return garage.Where(v => v.Color.Equals(color, StringComparison.OrdinalIgnoreCase) && v.NumberOfWheels == wheels);
        }

        // create a new garage with a specific capacity
        public void CreateNewGarage(int capacity)
        {
            garage = new Garage<Vehicle> (capacity);
            Console.WriteLine($"  new garage with capacity {capacity} has been created .");
        }
    }




}
