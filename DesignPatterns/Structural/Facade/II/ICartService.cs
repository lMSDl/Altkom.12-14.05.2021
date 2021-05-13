using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Structural.Facade.II
{
    public interface ICartService
    {
        float GetPrice(int cartId);
        void AddProduct(int cartId, int productId, float proce);
    }
}
