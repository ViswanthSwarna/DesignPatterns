using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Library
{
    public interface IStockCharter
    {
        void Visualize(string stockData);
    }
}
