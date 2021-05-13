using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Structural.Composite
{
    public class Client
    {
        public static void Execute()
        {
            var storage = new Container("Storage 1");
            var shelf1 = new Container("Shelf 1");
            var shelf2 = new Container("Shelf 2");
            var box1 = new Container("Box 1");
            var box2 = new Container("Box 2");
            var box3 = new Container("Box 3");
            var box4 = new Container("Box 4");
            var box5 = new Container("Box 5");

            var product1 = new Product("Kawa", 15.3f);
            var product2 = new Product("Herbata", 10f);
            var product3 = new Product("Ciastka", 12f);

            storage.Add(shelf1);
            storage.Add(shelf2);
            storage.Add((ProductBase)product3.Clone());

            shelf1.Add(box1);
            shelf1.Add(box3);
            shelf1.Add(box5);
            shelf1.Add((ProductBase)product1.Clone());

            shelf2.Add(box2);
            shelf2.Add(box4);

            for (var i = 0; i < 10; i++)
            {
                box1.Add((ProductBase)product1.Clone());
            }
            for (var i = 0; i < 10; i++)
            {
                box2.Add((ProductBase)product2.Clone());
            }
            for (var i = 0; i < 10; i++)
            {
                box3.Add((ProductBase)product3.Clone());
            }
            for (var i = 0; i < 5; i++)
            {
                box4.Add((ProductBase)product1.Clone());
                box4.Add((ProductBase)product2.Clone());
            }
            for (var i = 0; i < 3; i++)
            {
                box5.Add((ProductBase)product1.Clone());
                box5.Add((ProductBase)product2.Clone());
                box5.Add((ProductBase)product3.Clone());
            }


            storage.TotalPrice();
            shelf1.TotalPrice();
            box3.TotalPrice();
            Console.WriteLine($"Wartość {product3.Name} to: {product3.TotalPrice()}");
        }
    }
}
