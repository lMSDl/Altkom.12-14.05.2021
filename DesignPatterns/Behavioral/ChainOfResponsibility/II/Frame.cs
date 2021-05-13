using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    public class Frame : Container
    {
        protected override void Click(bool handled)
        {
            Console.WriteLine("Frame flashing");
            base.Click(handled);
        }
    }
}
