using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Structural.Adapter.II
{
    public class Client
    {
        public static void Execute()
        {
            var service = new DbPeopleService();
            var serviceAdapter = new DbServiceAdapter(service);

            serviceAdapter.Get().ToList().ForEach(ToString);

        }

        public static void ToString(Person person)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
    }
}
