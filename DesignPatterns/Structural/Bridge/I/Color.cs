using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Structural.Bridge.I
{
    public abstract class Color
    {
        public Brightness Brightness { get; set; }

        public abstract string ColorValue { get; }

        public override string ToString()
        {
            return Brightness == null ? ColorValue : Brightness.Value+ColorValue;
        }
    }
}
