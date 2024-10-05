using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Garage_1._0.vehicle;

namespace Garage_1._0
{
    public interface IHandler
    {
        // Park a vehicle in the garage
        void ParkVehicle(Vehicle vehicle);


        // Remove a vehicle from the garage by its registration number
        void RemoveVehicle(string registrationNumber);


        // Search for vehicles based on color and number of wheels
        IEnumerable<Vehicle> SearchVehicles(string color, int wheels);


        // List all vehicles currently parked in the garage
        IEnumerable<Vehicle> ListAllVehicles();


        // Get a count of each type of vehicle in the garage
        Dictionary<string, int> GetVehicleTypesAndCounts();



        // Create a new garage with a specified capacity
        void CreateNewGarage(int capacity);
    }



}
