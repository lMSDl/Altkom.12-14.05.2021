using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Behavioral.Visitor.I
{
    public class HtmlConverter : IVisitor
    {
        public string Output { get; set; } = string.Empty;

        public void Visit(BoldText boldText)
        {
            Output += $"<b>{boldText.Bold}</b>";
        }


        public void Visit(PlainText plainText)
        {
            Output += plainText.Plain;
        }

        public void Visit(Hyperlink hyperlink)
        {
            Output += $@"<a href=""{hyperlink.Link}"">{hyperlink.Label}</a>";
        }
    }
}
