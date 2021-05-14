using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Behavioral.Visitor.I
{
    public class Hyperlink : IElement
    {
        public string Link { get; set; }
        public string Label { get; set; }

        public void Accept(IVisitor visitor)
        {            
            visitor.Visit(this);
        }
    }
}
