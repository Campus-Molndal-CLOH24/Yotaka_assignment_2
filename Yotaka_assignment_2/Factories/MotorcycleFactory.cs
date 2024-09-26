using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yotaka_assignment_2.Interfaces;
using Yotaka_assignment_2.Models;

namespace Yotaka_assignment_2.Factories
{
    public class MotorcycleFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle(string model, int year, double mileage)
        {
            // Implementing the missing method from IVehicleFactory interface
            return new MotorcycleImpl("DefaultBrand", model, year, mileage, "DefaultEngineType");
        }

        
    }
}
