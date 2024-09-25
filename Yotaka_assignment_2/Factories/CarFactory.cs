﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yotaka_assignment_2.Interfaces;
using Yotaka_assignment_2.Models;

namespace Yotaka_assignment_2.Factories
{
    public class CarFactory : IVehicleFactory
    {
        public Car CreateCar(string band, string model, int year, double mileage, int doors)
        {
            return new Car
            {
                Brand = band,
                Model = model,
                Year = year,
                Mileage = mileage,
                Doors = doors,
                EngineType = "Petrol"
            };
        }

        
    }
}
