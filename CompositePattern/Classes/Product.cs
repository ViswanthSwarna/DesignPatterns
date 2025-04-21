using CompositePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Classes
{
    public class Product : IItem
    {
        private int value;
        public Product(int value)
        {
            this.value = value;
        }
        public double calculate()
        {
            return 5 * value;
        }
    }
}
