using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Creational.AbstractFactory
{
    class Client
    {
        public static void Execute()
        {
            Order order;
            Console.WriteLine("\r\n------------This is HONDA Car Factory----------------");
            order = new Order(new HondaFactory(), "compact", typeof(ISedan));
            Console.WriteLine("\r\n Manufactureing " + order.ManufacturedCarName() + " as compact Sedan");

            order = new Order(new HondaFactory(), "full", typeof(ISedan));
            Console.WriteLine("\r\n Manufactureing " + order.ManufacturedCarName() + " as full Sedan");

            Console.WriteLine("\r\n\r\n------------This is TOYOTA Car Factory----------------");
            order = new Order(new ToyotaFactory(), "compact", typeof(ISedan));
            Console.WriteLine("\r\n Manufactureing " + order.ManufacturedCarName() + " as compact Sedan");

            order = new Order(new ToyotaFactory(), "full", typeof(ISedan));
            Console.WriteLine("\r\n Manufactureing " + order.ManufacturedCarName() + " as full Sedan");
            Console.ReadLine();
        }
    }
}
