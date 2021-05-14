using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Behavioral.TemplateMethod
{
    public class FileLogger : Logger<string, StreamWriter>
    {
        public string FileLocation { get; set; }

        protected override void LogMessage(StreamWriter service, string info)
        {
            Console.WriteLine("Appending Log message to file : " + info);
            service.WriteLine(info);
        }

        protected override StreamWriter GetService()
        {
            Console.WriteLine("Opening File.");
            //var stream = File.OpenWrite(FileLocation);
            var stream = new MemoryStream();
            return new StreamWriter(stream);
        }

        protected override string ConvertMessage(string message)
        {
            Console.WriteLine("Serializing message");
            return message.ToString();
        }
    }
}
