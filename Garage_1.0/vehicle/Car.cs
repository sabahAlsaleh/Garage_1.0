using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_1._0.vehicle
{
    public class Car : Vehicle
    {
        public string FuelType { get; set; }  // Unique property for Car (e.g., Gasoline/Diesel)

        public Car (string registrationNumber, string color, int numberOfWheels, string fuelType)
            : base(registrationNumber, color, numberOfWheels)
        {
             FuelType =  fuelType ;
        }

        public override string ToString()
        {
              return $"Car [Reg. Number: {RegistrationNumber}, Color: {Color}, Wheels: {NumberOfWheels}, Fuel Type: {FuelType}]";
        }
    }


}
