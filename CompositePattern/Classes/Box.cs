using CompositePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Classes
{
    public class Box : IItem
    {
        private List<IItem> items;
        private int size;
        public Box(int size, List<IItem> items)
        {
            this.size = size;
            this.items = items;
        }
        public double calculate()
        {
            double total = 0.00;
            if (items != null)
            {
                foreach (IItem item in items)
                {
                    total += item.calculate();
                }
            }
            return 10 * size + total;
        }
    }
}
