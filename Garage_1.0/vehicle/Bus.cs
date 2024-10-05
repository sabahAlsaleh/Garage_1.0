using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_1._0.vehicle
{
    public class Bus : Vehicle
    {
         public int NumberOfSeats  {  get ; set; }  // Unique property for Bus class

        public Bus(string registrationNumber, string color, int numberOfWheels, int numberOfSeats)
            : base(registrationNumber, color, numberOfWheels)
        {
            NumberOfSeats = numberOfSeats;
        }

        public override string ToString()
        {
            return $"Bus [Reg. Number: {RegistrationNumber} , Color: {Color }, Wheels:  {NumberOfWheels} , Seats : {NumberOfSeats}]";
        }
    }

}
