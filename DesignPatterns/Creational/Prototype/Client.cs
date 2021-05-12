using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Creational.Prototype
{
    public class Client
    {
        public static void Execute()
        {
            var p1 = new Person
            {
                Age = 23,
                Name = "Adam Adamski",
                IdInfo = new IdInfo()
            };
            p1.Addresses.Add("Warszawska 15, 11-111 Warszawa");

            var p2 = (Person)p1.Clone();
            p2.Name = "Ewa Adamska";
            p2.Addresses.Add("Łódzka 71, 22-222 ŁÓDŹ");
            p2.IdInfo.IdNumber = Guid.NewGuid();

            Display(p1);
            Display(p2);
        }

        public static void Display(Person person)
        {
            Console.WriteLine($"Name: {person.Name}, Age {person.Age}");
            Console.WriteLine($"ID: {person.IdInfo.IdNumber}");
            person.Addresses.ForEach(x => Console.WriteLine($"Address: {x}"));
        }
    }
}
