using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yotaka_assignment_2.Interfaces
{
    public interface ICar : IVehicle, IDriveable
    {
        public int Doors { get; set; }
        public string EngineType { get; set; }

        public bool IsEngineOn();
        public void StartEngine();
        public void StopEngine();
        public string Drive();
    }
    class Car : ICar
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Mileage { get; set; }
        public int Doors { get; set; }
        public string EngineType { get; set; }

        public bool IsEngineOn()
        {
            return true;
        }

        public void StartEngine()
        {
            Console.WriteLine("The engine is on.");
        }

        public void StopEngine()
        {
            Console.WriteLine("The engine is off.");
        }
        public string Drive()
        {
            return "The car is driving.";
        }
    }
}
