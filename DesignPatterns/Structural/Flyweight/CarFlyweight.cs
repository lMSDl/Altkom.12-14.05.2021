using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Structural.Flyweight
{
    public class CarFlyweight
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public void Operation(Car uniqueState)
        {
            string s = JsonConvert.SerializeObject(this);
            string u = JsonConvert.SerializeObject(uniqueState);

            Console.WriteLine($"Flyweight:\ns: {s}\nu: {u}");
        }
    }
}
