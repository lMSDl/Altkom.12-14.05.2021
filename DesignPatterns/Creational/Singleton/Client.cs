﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Creational.Singleton
{
    public class Client
    {
        public static void Execute()
        {
            var service1 = Context.Instance.GetSettings("1");
            Console.WriteLine($"Service: {service1}");

            var service2 = Context.Instance.GetSettings("2");
            Console.WriteLine($"Service: {service2}");

            Context.Instance.SetSettings("2", "X");
            service2 = Context.Instance.GetSettings("2");
            Console.WriteLine($"Service: {service2}");
        }
    }
}
