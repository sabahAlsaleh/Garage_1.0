﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_1._0.vehicle
{
    public abstract class  Vehicle
    {
        public string RegistrationNumber { get ; private set; }
        public string Color  { get ; private set; }
        public int NumberOfWheels  { get ; private set; }


        public Vehicle (  string registrationNumber ,  string color , int numberOfWheels )
        {
            RegistrationNumber =  registrationNumber ;
            Color = color ;
            NumberOfWheels = numberOfWheels;


        }



    }

}
