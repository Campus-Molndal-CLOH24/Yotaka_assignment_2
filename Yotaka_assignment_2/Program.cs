using Yotaka_assignment_2.Models;
using Yotaka_assignment_2.Factories;
using Yotaka_assignment_2.Interfaces;
using System;
using System.Runtime.ConstrainedExecution;

namespace Yotaka_assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarFactory carfactory = new CarFactory();
            MotorcycleFactory motorcyclefactory = new MotorcycleFactory();

            //create list of vehicles
            List<IVehicle> vehicles = new List<IVehicle>();
            {
                vehicles.Add(carfactory.CreateVehicle("Toyota", "Jazz", 2011, 2000, 4, "Standard", 120));
                vehicles.Add(carfactory.CreateVehicle("Honda", "Civic", 2018, 2000, 4, "XV-200", 200));
                vehicles.Add(carfactory.CreateVehicle("Tesla", "Model S", 2019, 1000, 4, "XV-300", 150));
                vehicles.Add(motorcyclefactory.CreateVehicle("Harley Davidson", "Sportster", 2019, 5000, "V-Twin", 120));
                vehicles.Add(motorcyclefactory.CreateVehicle("Yamaha", "R1", 2017, 3000, "V-4", 180));
                vehicles.Add(motorcyclefactory.CreateVehicle("Kawasaki", "Ninja", 2018, 2500, "Inline-4", 200));
            };

            foreach (IVehicle vehicle in vehicles)
            {
                DisplayVehicleInfo(vehicle);
            }
            static void DisplayVehicleInfo(IVehicle vehicle)
            {
                Console.WriteLine(vehicle.ToString());
                vehicle.StartEngine();

                if (vehicle is CarImpl car)
                {
                    car.TrunOnRadio();
                }
                else if (vehicle is MotorcycleImpl motorcycle)
                {
                    motorcycle.Getspeed();
                    motorcycle.PutOnHelmet();
                }
                Console.WriteLine();
            }

            
        }
    }
}
