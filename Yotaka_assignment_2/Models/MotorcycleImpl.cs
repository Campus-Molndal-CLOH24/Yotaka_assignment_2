using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yotaka_assignment_2.Interfaces;
using Yotaka_assignment_2.Models;


namespace Yotaka_assignment_2.Models
{
    public class MotorcycleImpl : IMotorcycle, IVehicle, IDriveable
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Mileage { get; set; }
        public string EngineType { get; set; }
        private bool engineOn;

        //constructor
        public MotorcycleImpl(string brand, string model, int year, double mileage, string enginetype)
        {
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
            this.Mileage = mileage;
            this.EngineType = enginetype;
        }

        //methods
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
            if (engineOn)
            {
                return "The motorcycle is driving.";
            }
            else
            {
                return "Start the engine first.";
            }
        }

        public override string ToString()
        {
            return $"Year : {Year} Brand : {Brand} Model :  {Model} and Engine : {EngineType}.";
        }
    }
}
