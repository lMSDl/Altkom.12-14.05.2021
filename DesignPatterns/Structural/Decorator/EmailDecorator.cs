using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Structural.Decorator
{
    class EmailDecorator : BaseDecorator
    {
        public EmailDecorator(INotification notification) : base(notification)
        {
        }

        protected override void DecoratorSend(string message)
        {
            Console.WriteLine("Email notification has been send: " + message);
        }
    }
}
