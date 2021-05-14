using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Behavioral.Visitor.II
{
    public class Cart : Basket
    {
        public override void Add(Product product)
        {
            Console.WriteLine("Produkt w wózku");
        }

        public override void Add(BoxedProduct product)
        {
            Console.WriteLine("Całe opakowanie produktu w wózku");
        }
    }
}
