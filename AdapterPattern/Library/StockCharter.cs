using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Library
{
    public class StockCharter : IStockCharter
    {
        public void Visualize(string stockData)
        {
            Console.WriteLine($"stock data:{stockData}");
        }
    }
}
