using IteratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Classes
{
    public class CustomCollection : ICustomCollection
    {
        private Dictionary<string, string> items = new Dictionary<string, string>();
        public CustomCollection()
        {
            items.Add("1", "1");
            items.Add("2", "2");
            items.Add("3", "3");
            items.Add("4", "4");
        }

        public Dictionary<string, string> GetItems()
        {
            return items;
        }

        public IIterator<List<string>> GetIterator()
        {
            return new CustomCollectionIterator(this);
        }

    }
}
