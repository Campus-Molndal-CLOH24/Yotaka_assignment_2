using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yotaka_assignment_2.Interfaces;


namespace Yotaka_assignment_2.Models
{
    public class MotorcycleImpl : IMotorcycle, IVehicle
    {
        public string EngineType { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Mileage { get; set; }
        public int Doors { get; set; } // Implementing the missing property

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
    }
}
