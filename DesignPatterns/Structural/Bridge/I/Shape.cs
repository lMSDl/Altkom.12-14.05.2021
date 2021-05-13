using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Structural.Bridge.I
{
    public abstract class Shape
    {
        public Color Color { get; set; }

        public override string ToString()
        {
            return Color != null ? $"{Color}{GetType().Name}" : $"{GetType().Name}";
        }
    }
}
