using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yotaka_assignment_2.Interfaces;

namespace Yotaka_assignment_2.Models
{
    public class Car : ICar
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

        string IVehicle.IsEngineOn()
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

        public string Drive()
        {
            return "The car is driving.";
        }

        public override string ToString()
        {
            return $"{Year} {Brand} {Model} with {Doors} doors and a {EngineType} engine.";
        }
    }
}
