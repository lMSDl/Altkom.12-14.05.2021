using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Structural.Composite
{
    public class Container : ProductBase
    {
        private readonly ICollection<ProductBase> _content;

        public Container(string name) : base(name)
        {
            _content = new List<ProductBase>();
        }

        public void Add(ProductBase product)
        {
            _content.Add(product);
        }

        public override float TotalPrice()
        {
            var sum = _content.Sum(x => x.TotalPrice());
            Console.WriteLine($"Wartość {Name} to: {sum}");
            return sum;
        }
    }
}
