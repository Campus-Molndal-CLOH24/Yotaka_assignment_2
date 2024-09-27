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
                vehicles.Add(carfactory.CreateVehicle("Toyota", 2011, 2000));
                vehicles.Add(carfactory.CreateVehicle("Honda", "Civic", 2018, 2000, 4, "XV-200", 200));
                vehicles.Add(new CarImpl("Tesla", "Model S", 2019, 1000, 4, "XV-300", 150));
                vehicles.Add(new MotorcycleImpl("Harley Davidson", "Sportster", 2019, 5000, "V-Twin"));
                vehicles.Add(new MotorcycleImpl("Yamaha", "R1", 2017, 3000, "V-4"));
                vehicles.Add(new MotorcycleImpl("Kawasaki", "Ninja", 2018, 2500, "Inline-4"));
            };
            // choose switch case to display the vehicle type , it will be more nice and clean code.
            foreach (IVehicle vehicle in vehicles)
            {
                // use tostring to display all then chosee one if is car what is going to happen and if is motorcycle what is going to happen.
                switch (vehicle)
                { 
                    case CarImpl car:
                        Console.WriteLine(car.ToString());
                        car.StartEngine();
                        car.Getspeed();
                        car.TrunOnRadio();
                        Console.WriteLine();
                        break;
                    case MotorcycleImpl motorcycle:
                        Console.WriteLine(motorcycle.ToString());
                        motorcycle.StartEngine();
                        Console.WriteLine(motorcycle.Drive());
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
