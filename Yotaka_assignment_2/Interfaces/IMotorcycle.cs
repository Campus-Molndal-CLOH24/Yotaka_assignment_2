using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yotaka_assignment_2.Models;
using Yotaka_assignment_2.Factories;

namespace Yotaka_assignment_2.Interfaces
{
    public interface IMotorcycle : IVehicle, IDriveable
    {
        string EngineType { get; set; }
      
        void StartEngine();
        void StopEngine();
        string Drive();


        
    }
}
