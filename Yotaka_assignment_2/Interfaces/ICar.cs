using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yotaka_assignment_2.Interfaces
{
    public interface ICar : IVehicle, IDriveable
    {
        public int Doors { get; set; }
        public string EngineType { get; set; }

        public bool IsEngineOn();
        public void StartEngine();
        public void StopEngine();
        public string Drive();
    }
}
