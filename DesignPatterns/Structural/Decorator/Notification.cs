using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Structural.Decorator
{
    public class Notification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("Wysłano wewnętrzną notyfikację: " + message);
        }
    }
}
