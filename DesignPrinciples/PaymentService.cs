using System;
using System.Collections.Generic;
using System.Linq;

namespace DPCSharp.DesignPrinciples
{
    public class PaymentService
    {
        private ICollection<PaymentAccount> Customers { get; } = new List<PaymentAccount> { new PaymentAccount(1), new PaymentAccount(2), new PaymentAccount(3), new PaymentAccount(4), new PaymentAccount(5) };


        public PaymentAccount FindById(float id)
        {
            return Customers.SingleOrDefault(x => x.Id == id);
        }

        public bool Charge(int id, float amount)
        {
            var customer = FindById(id);
            return customer?.Charge(amount) ?? false;
        }

        public void Fund(int id, float amount)
        {
            var customer = FindById(id);
            customer?.Fund(amount);
        }
    }
}
