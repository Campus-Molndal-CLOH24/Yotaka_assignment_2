using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yotaka_assignment_2.Interfaces
{
    public interface IVehicle
    {
        string Brand { get; set; }
        string Model { get; set; }
        int Year { get; set; }
        double Mileage { get; set; }
        

        string IsEngineOn();

        void StartEngine();

        void StopEngine();
    }
}
