using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    public class Button : Component
    {
        public Func<bool> Func { get; set; }

        protected override void Click(bool handled)
        {
            if (handled)
                base.Click(true);
            else
            {
                if (Func())
                    base.Click(true);
                else
                    base.Click(false);
            }
        }

    }
}
