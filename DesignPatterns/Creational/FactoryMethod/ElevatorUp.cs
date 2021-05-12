using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Creational.FactoryMethod
{
    class ElevatorUp : IElevatorOperation
    {
        public void Operate(int floor)
        {
            Console.WriteLine($"Winda zatrzyma się na piętrze {floor} podczas jazdy do góry");
        }
    }
}
