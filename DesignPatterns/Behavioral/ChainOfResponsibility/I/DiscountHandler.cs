using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    class DiscountHandler : BaseHandler<IDiscountHandler>, IDiscountHandler
    {
        public string Name { get; }
        public float MaxDiscount { get; }
        public float MinPrice { get; }
        public DiscountHandler(string name, float maxDiscount, float minPrice) : this(name, maxDiscount, minPrice, null)
        {
        }
        public DiscountHandler(string name, float maxDiscount, float minPrice, IDiscountHandler handler) : base(handler)
        {
            Name = name;
            MaxDiscount = maxDiscount;
            MinPrice = minPrice;
        }

        public bool Discount(float value, float price)
        {
            if(MaxDiscount >= value && price >= MinPrice)
            {
                Console.WriteLine($"Rabat przyznany przez {Name}");
                return true;
            }
            return NextHandler?.Discount(value, price) ?? false;
        }
    }
}
