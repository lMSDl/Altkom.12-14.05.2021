using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Creational.FactoryMethod
{
    class Client
    {
        public static void Execute()
        {
            var elevator = new Elevator();

            var action = "Down";
            var floor = 3;
            elevator.Execute(action, floor);
            floor = 6;
            elevator.Execute(action, floor);
            floor = 1;
            elevator.Execute("GoTo", floor);
        }
    }
}
