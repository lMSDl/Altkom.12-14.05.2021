using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Structural.Bridge.II
{
    public class ShortMessageAbstraction : MessageAbstraction
    {
        public ShortMessageAbstraction(IMessageSenderImplementation messageSender) : base(messageSender)
        {
        }

        public override void Send(string message)
        {
            if(message.Length > 10)
                Console.WriteLine("Message too long...");
            else
             base.Send(message);
        }
    }
}
