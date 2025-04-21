using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Interfaces
{
    public interface ICustomCollection
    {
        IIterator<List<string>> GetIterator();

        Dictionary<string, string> GetItems();
    }
}
