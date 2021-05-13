using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Structural.Bridge.I
{
    public static class Client
    {
        public static void Execute()
        {
            var circle = new Circle();

            Console.WriteLine(circle);

            circle.Color = new Red();
            Console.WriteLine(circle);

            var square = new Square() { Color = new Blue() {Brightness = new Dark() } };
            Console.WriteLine(square);
        }
    }
}
