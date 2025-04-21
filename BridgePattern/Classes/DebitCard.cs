using BridgePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Classes
{
    public class DebitCard : IPaymentInstrument
    {
        public void Pay()
        {
            Console.WriteLine("Pay via debit");
        }
    }
}
