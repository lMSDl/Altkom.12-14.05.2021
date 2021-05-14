using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Behavioral.Visitor.II
{
    public class Client
    {
        public static void Execute()
        {
            var products = new Product[] { new Product(), new BoxedProduct() };
            foreach (var item in products)
            {
                item.PrintType();
            }

            var baskets = new Basket[] { new Basket(), new Cart() };
            foreach (var product in products)
            {
                foreach (var basket in baskets)
                {
                    //basket.Add(product);
                    product.Accept(basket);
                }
            }
        }

    }
}
