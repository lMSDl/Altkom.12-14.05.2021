using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Structural.Flyweight
{
    public class Client
    {
        public static void Execute()
        {
            var factory = new FlyweightFactory(
                new CarFlyweight { Manufacturer = "Chevrolet", Model = "Camaro2018", Color = "Pink" },
                new CarFlyweight { Manufacturer = "Mercedes Benz", Model = "C300", Color = "Black" },
                new CarFlyweight { Manufacturer = "Mercedes Benz", Model = "C500", Color = "Red" },
                new CarFlyweight { Manufacturer = "BMW", Model = "M5", Color = "Red" },
                new CarFlyweight { Manufacturer = "BMW", Model = "X6", Color = "White" }
            );
            factory.ShowCache();

            Add(factory, new Car
            {
                RegistrationNumber = "CL234IR",
                Owner = "James Doe",
                Manufacturer = "BMW",
                Model = "M5",
                Color = "Red"
            });

            var car1 = new Car
            {
                RegistrationNumber = "CL2343R",
                Owner = "James Doe",
                Manufacturer = "BMW",
                Model = "X1",
                Color = "Red"
            };

            Add(factory, car1);

            var car2 = new Car
            {
                RegistrationNumber = "CLK2231",
                Owner = "James Doe",
                Manufacturer = "BMW",
                Model = "X1",
                Color = "Red"
            };

            Add(factory,car2);

            factory.ShowCache();

            var flyweight = new CarFlyweight() { Model = car2.Model, Manufacturer = car2.Model, Color = "Black" };
            car2.CarFlyweight = factory.GetFlyweight(flyweight);

            car2.CarFlyweight.Operation(car2);
            car1.CarFlyweight.Operation(car1);
        }

        static void Add(FlyweightFactory factory, Car car)
        {
            Console.WriteLine("\nClient: Adding a car to database.");

            var flyweight = factory.GetFlyweight(car.CarFlyweight);
            car.CarFlyweight = flyweight;

            flyweight.Operation(car);
        }
    }
}
