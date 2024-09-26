using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yotaka_assignment_2.Models;


namespace Yotaka_assignment_2.Interfaces
{
    //use IVevicle becuase want to focus on the common properties and methods between car, motorcycle and other vehicles.
    public interface IVehicleFactory
    {
        IVehicle CreateVehicle(string model, int year, double mileage);
    }
}
