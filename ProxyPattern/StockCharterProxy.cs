using ProxyPattern.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class StockCharterProxy : IStockCharter
    {
        private readonly IStockCharter stockCharter;
        public StockCharterProxy(IStockCharter stockCharter)
        {
            this.stockCharter = stockCharter;
        }
        public void Visualize(string stockData)
        {
            if(DateTime.Today.DayOfWeek != DayOfWeek.Sunday) 
            {
                this.stockCharter.Visualize(stockData);
            }
            else 
            {
                throw new Exception("Not Implemented");
            }

        }
    }
}
