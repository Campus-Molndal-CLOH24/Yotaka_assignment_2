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
        public int Doors { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Mileage { get; set; }
        public string EngineType { get; set; } // Added to implement ICar

        public string Drive()
        {
            throw new NotImplementedException();
        }

        public bool IsEngineOn()
        {
            throw new NotImplementedException();
        }

        public void StartEngine()
        {
            throw new NotImplementedException();
        }

        public void StopEngine()
        {
            throw new NotImplementedException();
        }

        // Added to implement IVehicle
        string IVehicle.IsEngineOn()
        {
            throw new NotImplementedException();
        }
    }
}
