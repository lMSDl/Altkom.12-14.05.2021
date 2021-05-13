using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Structural.Bridge.II
{
    public class EmailGate : IMessageSenderImplementation
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Wiadomość została wysłana przez Email: {message}");
        }
    }
}
