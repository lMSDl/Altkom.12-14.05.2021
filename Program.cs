using Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Creational.Builder;
using Altkom._12_14._05._2021.WPCSharp.SOLID.L2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            DesignPatterns.Creational.Prototype.Client.Execute();

        }

        private static void LSP()
        {
            var a = 5;
            var b = 3;


            Rectangle rectangle = new Square
            {
                A = a,
                B = b
            };

            Console.WriteLine($"{a} * {b} = ");

            ShowArea(rectangle);
        }

        public static void ShowArea(Rectangle rectangle)
        {
            Console.WriteLine(rectangle.Area);
        }
    }
}
