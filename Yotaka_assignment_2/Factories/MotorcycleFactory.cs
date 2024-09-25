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
        public IVehicle CreateMotorcycle(string brand, string model, int year, double mileage)
        {
            return new Motorcycle
            {
                Brand = brand,
                Model = model,
                Year = year,
                Mileage = mileage,
                EngineType = "Petrol" // set default engine type only temporarily.
            };
        }
        public IVehicle CreateCar(string brand, string model, int year, double mileage, int doors)
        {
            throw new NotImplementedException("Can not create a car");
        }
    }
}
