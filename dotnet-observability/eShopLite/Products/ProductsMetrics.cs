using System;
using System.Diagnostics.Metrics;

public class ProductsMetrics
{
    private readonly Counter<int> _serviceCalls;
    private readonly Counter<int> _stockChange;

    public ProductsMetrics(IMeterFactory meterFactory)
    {
        var meter = meterFactory.Create("eShopLite.Products");
        _stockChange = meter.CreateCounter<int>("eshoplite.products.stock_change", unit: "{stock}", description: "Amount of stock being changed through the product service.");
    }

    public void StockChange(int quantity)
    {
        _stockChange.Add(quantity);
    }
}