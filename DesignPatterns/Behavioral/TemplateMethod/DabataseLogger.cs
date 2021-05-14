using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Behavioral.TemplateMethod
{
    public class DatabaseLogger : Logger<LogEntity, DatabaseService>
    {
        protected override void LogMessage(DatabaseService service, LogEntity info)
        {
            Console.WriteLine("Inserting Log Message to DB table : " + info.Message);
            service.Create(info);
        }

        protected override DatabaseService GetService()
        {
            Console.WriteLine("Connecting to Database.");
            return new DatabaseService();
        }

        protected override string PrepareMessage(string message)
        {
            return message;
        }

        protected override LogEntity ConvertMessage(string message)
        {
            Console.WriteLine("Serializing message");
            return new LogEntity { Message = message, DateTime = DateTime.Now };
        }

        protected override void OnServiceClosed()
        {
            Console.WriteLine("Connection to Database closed.");
        }
    }
}