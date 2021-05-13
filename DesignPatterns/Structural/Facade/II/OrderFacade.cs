using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._12_14._05._2021.WPCSharp.DesignPatterns.Structural.Facade.II
{
    public class OrderFacade
    {
        private ICartService cartService;
        private IPaymentService paymentService;
        private IProductService productService;

        public OrderFacade(ICartService cartService, IPaymentService paymentService, IProductService productService)
        {
            this.cartService = cartService;
            this.paymentService = paymentService;
            this.productService = productService;
        }

        public void Order(int cartId, IEnumerable<int> productId)
        {
            foreach (var item in productId)
            {
                var price = productService.GetPrice(item);
                cartService.AddProduct(cartId, item, price);
            }
            paymentService.Pay(cartId, cartService.GetPrice(cartId));
        }
    }
}
