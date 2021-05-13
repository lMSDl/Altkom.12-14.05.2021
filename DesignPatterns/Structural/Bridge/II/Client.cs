using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Structural.Bridge.II
{
    class Client
    {
        public static void Execute()
        {
            Console.WriteLine("Send short SMS");
            MessageAbstraction message = new ShortMessageAbstraction(new SmsGate());
            message.Send(Console.ReadLine());


            Console.WriteLine("Send Email");
            message = new MessageAbstraction(new EmailGate());
            message.Send(Console.ReadLine());
        }
    }
}

