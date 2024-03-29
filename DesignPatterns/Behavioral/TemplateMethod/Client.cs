﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Behavioral.TemplateMethod
{
    public class Client
    {
        public static void Execute()
        {
            FileLogger fileLogger = new FileLogger();
            fileLogger.Log("Message to Log in File.");
            Console.WriteLine();
            EmailLogger emailLogger = new EmailLogger();
            emailLogger.Log("Message to Log via Email.");
            Console.WriteLine();
            DatabaseLogger databaseLogger = new DatabaseLogger();
            databaseLogger.Log("Message to Log in DB.");
        }
    }
}