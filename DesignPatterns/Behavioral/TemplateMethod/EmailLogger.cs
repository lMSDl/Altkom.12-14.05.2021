using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Behavioral.TemplateMethod
{
    public class EmailLogger : Logger<string, IDisposable>
    {
        protected override void LogMessage(IDisposable service, string info)
        {
            Console.WriteLine("Sending Email with Log Message : " + info);
        }

        protected override IDisposable GetService()
        {
            return null;
        }

        protected override string ConvertMessage(string message)
        {
            Console.WriteLine("Serializing message");
            return message.ToString();
        }
    }
}
