using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.Interface
{
    public abstract class PaymentType
    {
        public IBank bank;
        public PaymentType(IBank bank)
        {
            this.bank = bank;
        }
        public abstract void Pay();
    }
}
