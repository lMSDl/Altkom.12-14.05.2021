using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Behavioral.ChainOfResponsibility.I
{
    public interface IDiscountHandler
    {
        float MaxDiscount { get; }
        float MinPrice { get; }
        bool Discount(float value, float price);
    }
}
