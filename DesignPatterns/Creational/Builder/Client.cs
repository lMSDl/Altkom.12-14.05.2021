using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Creational.Builder
{
    public class Client
    {
        public static void Execute()
        {
            //var vehicle = new Vehicle(4, 5, 4, 500, 100);
            var vehicle = new VehicleBuilder()
            .SetWheels(4)
            .SetSeats(5)
            .SetDoors(4)
            .SetTrunkCapacity(500)
            .SetEnginePower(100)
            .Build();

            //vehicle = new Vehicle() { Wheels = 4, Seats = 5, Doors = 4, EnginePower = 100, TrunkCapacity = 500 };
            //vehicle = new Vehicle() { Wheels = 4, Seats = 5, TrunkCapacity = 500 };

            Console.WriteLine(vehicle);
        }
    }
}
