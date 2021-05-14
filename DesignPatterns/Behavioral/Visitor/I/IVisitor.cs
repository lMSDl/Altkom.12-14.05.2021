using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Behavioral.Visitor.I
{
    public interface IVisitor
    {
        void Visit(PlainText plainText);
        void Visit(BoldText boldText);
        void Visit(Hyperlink hyperlink);
    }
}
