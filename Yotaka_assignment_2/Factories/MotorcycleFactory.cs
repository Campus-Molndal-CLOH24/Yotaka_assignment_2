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
        public IVehicle CreateMotorcycle(string brand, string model, int year, double mileage, string enginetype)
        {
            return new MotorcycleImpl
            {
                Brand = brand,
                Model = model,
                Year = year,
                Mileage = mileage,
                EngineType = enginetype
            };
        }
        // why we need it : ask chat GPT 
        public IVehicle CreateCar(string brand, string model, int year, double mileage, int doors, string enginetype)
        {
            throw new NotImplementedException("Can not create a car becuase this factory create only motorcycle");
        }
    }
}
