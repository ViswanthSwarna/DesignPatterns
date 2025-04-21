using BridgePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Classes
{
    public class LongtermClient : Client
    {
        private IPaymentInstrument paymentInstrument;
        public LongtermClient(IPaymentInstrument paymentInstrument) : base(paymentInstrument)
        {
            this.paymentInstrument = paymentInstrument;
        }

        public override void BookOrder()
        {
            Console.WriteLine("Book Longterm Something");
            paymentInstrument.Pay();
            Console.WriteLine("Do SomethingElse");
        }
    }
}
