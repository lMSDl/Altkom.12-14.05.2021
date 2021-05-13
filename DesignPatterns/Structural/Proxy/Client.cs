﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Structural.Proxy
{
    public class Client
    {
        public static void Execute()
        {
            IDatabase database = new Database();
            database = new DatabaseProxy(database);

            for(var i = 1; i < 11; i++)
            {
                _ = database.RequestAsync(i);
            }

            Console.ReadLine();

            for (var i = 1; i < 11; i++)
            {
                _ = database.RequestAsync(i);
            }
        }
    }
}
