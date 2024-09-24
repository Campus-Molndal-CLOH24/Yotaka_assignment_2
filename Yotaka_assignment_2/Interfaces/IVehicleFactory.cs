using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yotaka_assignment_2.Interfaces
{
    public interface IVehicleFactory
    {
        IVehicle CreateVehicle(string brand, string model, int year, double mileage, int doors);

    }
}
