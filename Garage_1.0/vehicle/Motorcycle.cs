using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_1._0.vehicle
{
    public class Motorcycle :  Vehicle
    {
        public  int CylinderVolume {  get; set ; }  // Unique property for Motorcycle

        public  Motorcycle(string registrationNumber, string color, int numberOfWheels , int cylinderVolume )
            : base(registrationNumber, color, numberOfWheels)
         {
            CylinderVolume =  cylinderVolume;
         }

        public override string ToString()
         {
            return $"Motorcycle  [Reg. Number: {RegistrationNumber } , Color : {Color} , Wheels: {NumberOfWheels}, Cylinder Volume: {CylinderVolume}cc]";
         }
    }

}
