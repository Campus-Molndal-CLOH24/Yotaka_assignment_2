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
        public IVehicle CreateVehicle(string brand, string model, int year)
        {
            return new Motorcycle
            {
                Brand = brand,
                Model = model,
                Year = year,
                EngineType = "Petrol"
            };
        }
    }
}
