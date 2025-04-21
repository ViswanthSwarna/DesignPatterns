using AdapterPattern.Library;

namespace AdapterPattern
{
    public class StockCharterAdapter : IStockCharterAdapter
    {
        private readonly IStockCharter _stockCharter;
        public StockCharterAdapter(IStockCharter stockCharter)
        {
            this._stockCharter = stockCharter;
        }
        public void Visualize(Candle stockData)
        {
            _stockCharter.Visualize($"{stockData.High},{stockData.Low},{stockData.Open},{stockData.Close}");
        }
    }
}
