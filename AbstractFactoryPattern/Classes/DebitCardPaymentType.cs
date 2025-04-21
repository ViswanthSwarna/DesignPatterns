

using AbstractFactoryPattern.Interface;

namespace AbstractFactoryPattern.Classes
{
    public class DebitCardPaymentType : PaymentType
    {
        public DebitCardPaymentType(IBank bank) : base(bank)
        {
        }

        public override void Pay()
        {
            Console.WriteLine("Pay via debit card");
        }

    }
}
