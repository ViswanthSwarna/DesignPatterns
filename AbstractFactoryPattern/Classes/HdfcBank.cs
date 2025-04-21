using AbstractFactoryPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Classes
{
    public class HdfcBank : IBank
    {
        public PaymentType CreateCreditCard()
        {
            return new CreditCardPaymentType(this);
        }

        public PaymentType CreateDebitCard()
        {
            return new DebitCardPaymentType(this);
        }
    }
}
