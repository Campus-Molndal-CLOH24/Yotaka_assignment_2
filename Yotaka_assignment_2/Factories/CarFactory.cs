using System;
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
        // Implementing the missing method from IVehicleFactory interface
        public IVehicle CreateVehicle(string model, int year, double mileage)
        {
            // Assuming default values for brand, doors, and enginetype
            return new CarImpl("DefaultBrand", model, year, mileage, 4, "DefaultEngineType",0);
        }
    }
}
