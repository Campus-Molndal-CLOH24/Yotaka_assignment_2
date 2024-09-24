using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yotaka_assignment_2.Interfaces
{
    public interface IMotorcycle : IVehicle
    {
        string EngineType { get; set; }
    }
    class Motorcycle : IMotorcycle, IVehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Mileage { get; set; }
        public string EngineType { get; set; }
        private bool engineOn;

        public string IsEngineOn()
        {
            return engineOn ? "Engine is on" : "Engine is off";
        }

        public void StartEngine()
        {
            engineOn = true;
            Console.WriteLine("The engine is on.");
        }

        public void StopEngine()
        {
            engineOn = false;
            Console.WriteLine("The engine is off.");
        }
    }
}
