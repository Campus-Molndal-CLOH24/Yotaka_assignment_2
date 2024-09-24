using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yotaka_assignment_2.Interfaces;

namespace Yotaka_assignment_2.Factories
{
    public class CarFactory : IVehicleFactory
    {
        private string band;
        private string model;
        private int year;
        private double mileage;
        private int doors;

        public CarFactory(string band, string model, int year, double mileage, int doors)
        {
            this.band = band;
            this.model = model;
            this.year = year;
            this.mileage = mileage;
            this.doors = doors;
        }

        public CarFactory CreateCar(string band, string model, int year, double mileage, int doors)
        {
            return new CarFactory(band, model, year, mileage, doors);
        }

        public IVehicle CreateVehicle(string model, int year, double mileage)
        {
            throw new NotImplementedException();
        }
    }
}
