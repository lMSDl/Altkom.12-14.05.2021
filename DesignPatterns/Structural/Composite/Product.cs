using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Structural.Composite
{
    public class Product : ProductBase, ICloneable
    {
        public float Price { get; }
        public Product(string name, float price) : base(name)
        {
            Price = price;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public override float TotalPrice()
        {
            return Price;
        }
    }
}
