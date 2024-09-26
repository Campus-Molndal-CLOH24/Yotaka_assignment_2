﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yotaka_assignment_2.Interfaces;
using Yotaka_assignment_2.Models;

namespace Yotaka_assignment_2.Factories
{
    // build mall for cars to build a car when we call in car implement 
    public class CarFactory : IVehicleFactory
    {
        public IVehicle CreateCar(string brand, string model, int year, double mileage, int doors, string enginetype)
        {
            return new CarImpl(brand,model,year,mileage,doors,enginetype);
            
        }
        // note to myself : i defined it becuase it is required by the interface IVehicleFactory . maybe if user use this method it will throw an exception
        
        public IVehicle CreateMotorcycle(string brand, string model, int year, double mileage, string enginetype)
        {
            throw new NotImplementedException("Can not create a motorcycle");
        }
    }
}
