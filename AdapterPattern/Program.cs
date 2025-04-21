

using AdapterPattern;
using AdapterPattern.Library;

IStockCharterAdapter stockChart = new StockCharterAdapter(new StockCharter());
stockChart.Visualize(new Candle()
{Open =20.00, Close = 10.00, High = 25.00, Low = 5.00
});
