
using AbstractFactoryPattern.Interface;

namespace AbstractFactoryPattern.Classes
{
    public class CreditCardPaymentType : PaymentType
    {
        public CreditCardPaymentType(IBank bank) : base(bank)
        {
        }

        public override void Pay()
        {
            Console.WriteLine("Pay via credit card");
        }
    }
}
