﻿using StrategyPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Classes
{
    public class DebitCardPaymentStrategy : IPaymentStrategy
    {
        public void Pay()
        {
            Console.WriteLine("Pay via debit card");
        }
    }
}
