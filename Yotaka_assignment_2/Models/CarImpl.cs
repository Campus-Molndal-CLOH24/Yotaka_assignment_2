﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yotaka_assignment_2.Interfaces;
using Yotaka_assignment_2.Models;

namespace Yotaka_assignment_2.Models
{
    public class CarImpl : ICar, IVehicle, IDriveable
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Mileage { get; set; }
        public int Doors { get; set; }
        public string EngineType { get; set; }
        private bool engineOn;
        
        //constructor
        public CarImpl(string band, string Model, int year, double mileage, int doors, string enginetype)
        {
            this.Brand = band;
            this.Model = Model;
            this.Year = year;
            this.Mileage = mileage;
            this.Doors = doors;
            this.EngineType = enginetype; 
        }
        //methods
     
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
            return engineOn ? "Driving...." : "Engine is off , you should start the engine.";
        }
        public void TrunOnRadio()
        {
            if (engineOn)
            {
                Console.WriteLine("The radio is on.");
            }
            else
            {
                Console.WriteLine("Start the engine first.");
            }
        }
        public void Getspeed(int speed)
        {
            Console.WriteLine($"The car is driving at {speed} km/h.");
        }
        public override string ToString()
        {
            return $"Year : {Year} Brand :{Brand} Model : {Model} with {Doors} doors and a {EngineType} engine.";
        }
    }
}

