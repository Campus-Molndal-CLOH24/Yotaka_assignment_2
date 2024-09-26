using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yotaka_assignment_2.Interfaces;
using Yotaka_assignment_2.Models;


namespace Yotaka_assignment_2.Models
{
    public class MotorcycleImpl : IMotorcycle
    {
        public string Brand { get; set; }
        public string Model { get; set; } 
        public int Year { get; set; }
        public double Mileage { get; set; }
        public string EngineType { get; set; }
        public int Speed = 0;
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
        public void StartEngine()
        {
            engineOn = true;
            Console.WriteLine("The Motorcycle  engine is on.");
        }
        public void StopEngine()
        {
            engineOn = false;
            Console.WriteLine("The Motorcycle engine is off.");
        }
        // i want it will be different from car class so i will return different message
        public string Drive()
        {
            return engineOn ? "Motocycle is driving now" : "You should start engine first";
        }
        public void Getspeed(int speed)
        {
            //this.Speed = speed;
            Console.WriteLine($"Motorcycle is now going at {speed} km/h.");
        }

        public override string ToString()
        {
            return $"The Motorcycle : \n" +
                $"Year : {Year} \n" +
                $"Brand : {Brand} \n" +
                $"Model :  {Model} \n" +
                $"Spreed : {Speed} \n" +
                $" Engine : {EngineType}.";
        }
    }
}
