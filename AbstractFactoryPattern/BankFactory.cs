using AbstractFactoryPattern.Classes;
using AbstractFactoryPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class BankFactory
    {
        public static IBank CreateFactory(string bankType) 
        {
            IBank bank = null;
            if(bankType.Equals("HDFC"))
            {
                bank = new HdfcBank();
            }else if (bankType.Equals("ICICI")) 
            {
                bank = new IciciBank();
            }
            return bank;
        }
    }
}
