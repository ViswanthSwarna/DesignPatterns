using StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Classes
{
    public class PaymentProcessor
    {
        private IPaymentStrategy paymentStrategy;

        public void SetStrategy(IPaymentStrategy paymentStrategy) 
        {
            this.paymentStrategy = paymentStrategy;
        }

        public void ProcessPayment()
        {
            paymentStrategy.Pay();
        }
    }
}
