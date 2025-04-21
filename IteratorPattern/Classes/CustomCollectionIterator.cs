using IteratorPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Classes
{
    public class CustomCollectionIterator : IIterator<List<string>>
    {
        ICustomCollection collection;
        public CustomCollectionIterator(ICustomCollection collection)
        {
            this.collection = collection;
        }

        public List<string> Iterate()
        {
            return collection.GetItems().Select(x => x.Value).ToList();
        }
    }
}
