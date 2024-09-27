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
        public IVehicle CreateVehicle(string model, int year, double mileage)
        {
            return new CarImpl("Unknown", model, year, mileage, 4, "Unknown", 0);
        }
        // use over method to create a car becuase  it can create more properties so it prevent error when we call in car implement in program.cs
        // got help from chatgpt. It gave me 2 solution to solve the problem. I choose the first solution.
        public IVehicle CreateVehicle(string brand, string model, int year, double mileage, int doors, string engineType, int speed)
        {
            return new CarImpl(brand, model, year, mileage, doors, engineType, speed);
        }
    }
}
