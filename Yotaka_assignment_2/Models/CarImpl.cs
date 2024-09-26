using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yotaka_assignment_2.Interfaces;
using Yotaka_assignment_2.Models;

namespace Yotaka_assignment_2.Models
{
    public class CarImpl : ICar
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Mileage { get; set; }
        public int Doors { get; set; }
        public string EngineType { get; set; }
        int Speed { get; set; }
        private bool engineOn;
        
        //constructor
        public CarImpl(string band, string Model, int year, double mileage, int doors, string enginetype, int speed)
        {
            this.Brand = band;
            this.Model = Model;
            this.Year = year;
            this.Mileage = mileage;
            this.Doors = doors;
            this.Speed = speed;
            this.EngineType = enginetype; 
        }
        //methods
        public void StartEngine()
        {
            engineOn = true;
            Console.WriteLine("The car engine is on.");
        }
        public void StopEngine()
        {
            engineOn = false;
            Console.WriteLine("The car engine is off.");
        }
        public string Drive()
        {
            return engineOn ? "The car is Driving...." : "Engine is off , you should start the engine.";
        }
        public void TrunOnRadio()
        {
            Console.WriteLine(engineOn ? "The radio is on." : "Start the engine first then radio will trun on.");
        }
        public int Getspeed()
        {
            Console.WriteLine($"The car is driving at {Speed} km/h.");
            return this.Speed = Speed;
                
        }
        public override string ToString()
        {
            return $"The Car : \n" +
                $"Year : {Year} \n" +
                $"Brand :{Brand} \n" +
                $"Model : {Model} with {Doors} doors \n " +
                $"a {EngineType} engine.";
        }
    }
}

