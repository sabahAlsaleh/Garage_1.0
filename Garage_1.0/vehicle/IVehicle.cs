﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_1._0.vehicle
{
    public interface IVehicle
    {
        string RegistrationNumber { get; }
        string Color { get; }
        int NumberOfWheels { get; }
    }

}
