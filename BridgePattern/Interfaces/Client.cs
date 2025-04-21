using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Interfaces
{
    public abstract class Client
    {
        private readonly IPaymentInstrument paymentInstrument;
        public Client(IPaymentInstrument paymentInstrument)
        {
            this.paymentInstrument = paymentInstrument;
        }

        public abstract void BookOrder();
    }
}
