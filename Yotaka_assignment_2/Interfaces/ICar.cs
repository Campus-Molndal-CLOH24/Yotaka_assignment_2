using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yotaka_assignment_2.Interfaces
{
    public interface ICar : IVehicle, IDriveable
    {
        int Doors { get; set; }
        string EngineType { get; set; }

        bool IsEngineOn();
        void StartEngine();
        void StopEngine();
        string Drive();
    }
    
    class Car : ICar, IVehicle, IDriveable
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Mileage { get; set; }
        public int Doors { get; set; }
        public string EngineType { get; set; }
        private bool engineOn;

        public bool IsEngineOn()
        {
            return engineOn;
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

        public string Drive()
        {
            return "The car is driving.";
        }

        // Explicit implementation for IVehicle interface
        string IVehicle.IsEngineOn()
        {
            return engineOn ? "Engine is on" : "Engine is off";
        }
    }
}
