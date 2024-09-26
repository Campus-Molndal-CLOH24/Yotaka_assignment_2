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
            return new MotorcycleImpl(brand, model, year, mileage, enginetype);
        }

        public  IVehicle CreateCar(string brand, string model, int year, double mileage, int doors, string enginetype)
        {
            throw new NotImplementedException("Can not create a car because this factory creates only motorcycles");
        }
    }
}
