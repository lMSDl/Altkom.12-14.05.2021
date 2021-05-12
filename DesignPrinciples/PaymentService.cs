using System;
using System.Collections.Generic;
using System.Linq;

namespace DPCSharp.DesignPrinciples
{
    public class PaymentService
    {
        private ICollection<PaymentAccount> Customers { get; } = new List<PaymentAccount> { new PaymentAccount(1), new PaymentAccount(2), new PaymentAccount(3), new PaymentAccount(4), new PaymentAccount(5) };

        public bool DeleteCustomer(PaymentAccount param)
        {
            return Customers.Remove(param);
        }

        public PaymentAccount FindByAllowedDebit(float allowedDebit)
        {
            return Customers.SingleOrDefault(x => x.AllowedDebit == allowedDebit);
        }

        public PaymentAccount FindById(float id)
        {
            return Customers.SingleOrDefault(x => x.Id == id);
        }

        public bool Charge(int id, float amount)
        {
            var customer = FindById(id);
            if (customer == null)
                return false;

            if (GetBalance(id) + customer.AllowedDebit < amount)
                return false;

            customer.Outcomes += amount;
            return true;
        }

        public void Fund(int id, float amount)
        {
            var customer = FindById(id);
            if (customer == null)
                return;
            customer.Incomes += amount;
        }

        public float? GetBalance(int id)
        {
            var customer = FindById(id);
            return customer?.Incomes - customer?.Outcomes;
        }
    }
}
