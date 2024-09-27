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
        public int Speed { get; set; }
        private bool engineOn;

        //constructor
        public MotorcycleImpl(string brand, string model, int year, double mileage, string enginetype, int speed)
        {
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
            this.Mileage = mileage;
            this.EngineType = enginetype;
            this.Speed = speed;
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
        public string Drive()
        {
            return engineOn ? "Motocycle is riding now" : "You should start engine first";
        }
        public void Getspeed()
        {
            Console.WriteLine($"Motorcycle is now going at {Speed} km/h.");
        }
        public void PutOnHelmet()
        {
            Console.WriteLine("Helmet is on.");
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
