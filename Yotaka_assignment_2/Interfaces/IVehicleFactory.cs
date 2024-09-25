using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yotaka_assignment_2.Models;


namespace Yotaka_assignment_2.Interfaces
{
    //mallen base class to car and motorcycle factory 
    public interface IVehicleFactory
    {
        IVehicle CreateCar(string brand, string model, int year, double mileage, int doors, string enginetype);
        IVehicle CreateMotorcycle(string brand, string model, int year, double mileage, string enginetype);
    }
}
