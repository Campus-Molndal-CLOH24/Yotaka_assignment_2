using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yotaka_assignment_2.Models;

namespace Yotaka_assignment_2.Interfaces
{
    public interface ICar : IVehicle, IDriveable
    {
        int Doors { get; set; }
        string EngineType { get; set; }

        void StartEngine();
        void StopEngine();
        
        string Drive();
        void TrunOnRadio(); // added new method to turn on radio specifi only car
    }
    
}
