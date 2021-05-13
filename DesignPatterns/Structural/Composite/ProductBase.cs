using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Structural.Composite
{
    public abstract class ProductBase : IPrice
    {
        public string Name { get; }

        protected ProductBase(string name)
        {
            Name = name;
        }

        public abstract float TotalPrice();
    }
}
