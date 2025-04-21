using Factory.Classes;
using Factory.Inferface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class PaymentTypeFactory
    {
        public IPaymentType Create(string type) 
        {
            IPaymentType paymentType = null;

            if (type.Equals("1"))
            {
                paymentType = new CreditCardPaymentType();
            }
            else if (type.Equals("2"))
            {
                paymentType = new DebitCardPaymentType();
            }
            return paymentType;
        }
    }
}
