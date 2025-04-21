using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Inferface;

namespace Factory.Classes
{
    public class DebitCardPaymentType : IPaymentType
    {
        public void Pay()
        {
            Console.WriteLine("Pay via debit card");
        }
    }
}
