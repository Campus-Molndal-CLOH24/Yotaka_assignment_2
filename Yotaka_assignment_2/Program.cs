using Yotaka_assignment_2.Models;
using Yotaka_assignment_2.Factories;
using Yotaka_assignment_2.Interfaces;
using System;

namespace Yotaka_assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // Instantiate the specific factories
            CarFactory carFactory = new CarFactory();
            MotorcycleFactory motorcycleFactory = new MotorcycleFactory();

            // Create a car using the CarFactory
            var car = carFactory.CreateCar("Toyota", "Corolla", 2020, 15000, 4);
            Console.WriteLine(car);
            car.StartEngine(); 
            Console.WriteLine("Car engine status: " + (car.IsEngineOn() ? "On" : "Off"));
            car.StopEngine();
            Console.WriteLine("Car engine status: " + (car.IsEngineOn() ? "On" : "Off"));
            Console.WriteLine("Car doors: " + car.Doors);
            car.Doors = 5;
            Console.WriteLine("Car doors: " + car.Doors);

            // Create a motorcycle using the MotorcycleFactory

            var motorcycle = motorcycleFactory.CreateMotorcycle("Harley Davidson", "Sportster", 2019, 5000);
            motorcycle.EngineType = "V-Twin";
            Console.WriteLine(motorcycle);
            motorcycle.StartEngine();
            Console.WriteLine("Motorcycle engine status: " + (motorcycle.IsEngineOn() ? "On" : "Off"));
            motorcycle.StopEngine();
            Console.WriteLine("Motorcycle engine status: " + (motorcycle.IsEngineOn() ? "On" : "Off"));
            Console.WriteLine("Motorcycle engine type: " + motorcycle.EngineType);
            motorcycle.EngineType = "Inline-4";
            Console.WriteLine("Motorcycle engine type: " + motorcycle.EngineType);
            */
            // test run only car factory
            CarFactory carFactory = new CarFactory();
            IVehicle car = carFactory.CreateCar("Toyota", "Corolla", 2020,1700,5, "XV-100");
            car.StartEngine();
            Console.WriteLine(car.ToString());

            // test run only motorcycle factory
            MotorcycleFactory motorcycleFactory = new MotorcycleFactory();
            IVehicle motorcycle = motorcycleFactory.CreateMotorcycle("Harley Davidson", "Sportster", 2019, 5000, "V-Twin");
            motorcycle.StartEngine();
            motorcycle.Getspeed(200);
            Console.WriteLine(motorcycle.ToString());

        }
    }
    
}
