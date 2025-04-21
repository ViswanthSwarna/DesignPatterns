

using ProxyPattern;
using ProxyPattern.Library;

IStockCharter stockcharter = new StockCharterProxy(new StockCharter());
stockcharter.Visualize("hello");