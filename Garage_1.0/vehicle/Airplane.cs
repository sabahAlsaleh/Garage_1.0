using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_1._0.vehicle
{
    public class Airplane : Vehicle

    {
        public int NumberOfEngines { get; set; }

        public Airplane(string registrationNumber, string color, int numberOfWheels, int numberOfEngines)
            : base(registrationNumber, color, numberOfWheels)

        {
            NumberOfEngines = numberOfEngines;
        }
    }


}
