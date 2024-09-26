using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yotaka_assignment_2.Models;

namespace Yotaka_assignment_2.Interfaces
{
    //base class to be inherited to ICar and IMotorcycle
    public interface IVehicle
    {
        string Brand { get; set; }
        string Model { get; set; }
        int Year { get; set; }
        double Mileage { get; set; }

        
    }
}
