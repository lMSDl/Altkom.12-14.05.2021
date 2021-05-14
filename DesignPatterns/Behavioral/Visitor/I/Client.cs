using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Behavioral.Visitor.I
{
    public class Client
    {
        public static void Execute()
        {
            var collection = new IElement[] {
            new PlainText { Plain = "plain" },
            new PlainText { Plain = "\n" },
            new BoldText { Bold = "bold" },
            new PlainText { Plain = "\n" },
            new Hyperlink { Link = "http:\\some.url.com", Label="Some Url Company" }
            };

            var converter = new HtmlConverter();
            foreach (var item in collection)
            {
                item.Accept(converter);
            }

            Console.WriteLine(converter.Output);
        }
    }
}
