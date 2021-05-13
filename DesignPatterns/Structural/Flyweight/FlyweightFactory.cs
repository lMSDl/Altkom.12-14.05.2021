using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Structural.Flyweight
{
    public class FlyweightFactory
    {
        private readonly Dictionary<string, CarFlyweight> _flyweights;

        public FlyweightFactory() : this(new CarFlyweight[0])
        {
        }

        public FlyweightFactory(params CarFlyweight[] flyweights)
        {
            _flyweights = flyweights.ToDictionary(x => GetKey(x));
        }

        public string GetKey(CarFlyweight carFlyweight)
        {
            return string.Join("_", carFlyweight.GetType().GetProperties().Select(x => x.GetValue(carFlyweight).ToString()));
        }

        public CarFlyweight GetFlyweight(CarFlyweight carFlyweight)
        {
            var key = GetKey(carFlyweight);

            if(_flyweights.TryGetValue(key, out var flyweight))
            {
                Console.WriteLine("FlyweightFactory: zwracam obiekt z cache");
                return flyweight;
            }

            Console.WriteLine("FlyweightFactory: dodaję obiekt do cache");
            _flyweights.Add(key, carFlyweight);
            return carFlyweight;
        }

        public void ShowCache()
        {
            Console.WriteLine($"\nW cache mam {_flyweights.Count} obiektów:");
            foreach (var item in _flyweights)
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}
