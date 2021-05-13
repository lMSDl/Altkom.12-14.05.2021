using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Structural.Decorator
{
    public class Client
    {

        public static void Execute()
        {
            var test = Console.ReadLine();

            var notification = (INotification)new Notification();
            if (test.Length <= 10)
                notification = new SmsDecorator(notification);
            notification = new EmailDecorator(notification);

            notification.Send(test);
        }
    }
}
