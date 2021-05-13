using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Structural.Flyweight
{
    public class Car
    {
        public string Owner { get; set; }
        public string RegistrationNumber { get; set; }
        public string Manufacturer { get => CarFlyweight.Manufacturer; set => CarFlyweight.Manufacturer = value; }
        public string Model { get => CarFlyweight.Model; set => CarFlyweight.Model = value; }
        public string Color { get => CarFlyweight.Color; set => CarFlyweight.Color = value; }

        [JsonIgnore]
        public CarFlyweight CarFlyweight { get; set; } = new CarFlyweight();
    }
}
