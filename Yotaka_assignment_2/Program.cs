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
            //create list of vehicles
            List<IVehicle> vehicles = new List<IVehicle>();
            {
                vehicles.Add(new CarImpl("Toyota", "Corolla", 2020, 1700, 5, "XV-100"));
                vehicles.Add(new MotorcycleImpl("Harley Davidson", "Sportster", 2019, 5000, "V-Twin"));
                vehicles.Add(new CarImpl("Honda", "Civic", 2018, 2000, 4, "XV-200"));
                vehicles.Add(new MotorcycleImpl("Yamaha", "R1", 2017, 3000, "V-4"));
            };
            foreach (IVehicle vehicle in vehicles)
            {
                switch (vehicle)
                { 
                    case CarImpl car:
                        Console.WriteLine(car.ToString());
                        car.StartEngine();
                        car.Getspeed(100);
                        car.TrunOnRadio();
                        Console.WriteLine(car.Drive());
                        Console.WriteLine();
                        break;
                    case MotorcycleImpl motorcycle:
                        Console.WriteLine("This is a Motorcycle");
                        motorcycle.StartEngine();
                        Console.WriteLine(motorcycle.Drive());
                        Console.WriteLine(motorcycle.ToString());
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Invalid vehicle type");
                        break;
                }
            }
        }
    }
    
}
