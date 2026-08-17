using System;
using System.Collections.Generic;

// ==========================================
// 1. Custom Observer Interface
// ==========================================

public interface IStockObserver
{
    void Update(string stockName, decimal price);
}

public class StockInvestor : IStockObserver
{
    private string name;

    public StockInvestor(string name)
    {
        this.name = name;
    }

    public void Update(string stockName, decimal price)
    {
        Console.WriteLine(
            $"{name} notified: {stockName} price changed to {price}");
    }
}

public class StockTickerObserver
{
    private List<IStockObserver> investors =
        new List<IStockObserver>();

    public void Subscribe(IStockObserver investor)
    {
        investors.Add(investor);
    }

    public void Unsubscribe(IStockObserver investor)
    {
        investors.Remove(investor);
    }

    public void SetPrice(string stockName, decimal price)
    {
        Console.WriteLine(
            $"\nObserver Pattern: {stockName} = {price}");

        foreach (IStockObserver investor in investors)
        {
            investor.Update(stockName, price);
        }
    }
}


// ==========================================
// 2. C# Events Version
// ==========================================

public class StockTickerEvent
{
    public event EventHandler<StockPriceChangedEventArgs> PriceChanged;

    public void SetPrice(string stockName, decimal price)
    {
        Console.WriteLine(
            $"\nEvent Pattern: {stockName} = {price}");

        PriceChanged?.Invoke(
            this,
            new StockPriceChangedEventArgs(stockName, price));
    }
}

public class StockPriceChangedEventArgs : EventArgs
{
    public string StockName { get; }
    public decimal Price { get; }

    public StockPriceChangedEventArgs(
        string stockName,
        decimal price)
    {
        StockName = stockName;
        Price = price;
    }
}

public class EventInvestor
{
    private string name;

    public EventInvestor(string name)
    {
        this.name = name;
    }

    public void OnPriceChanged(
        object sender,
        StockPriceChangedEventArgs e)
    {
        Console.WriteLine(
            $"{name} notified: {e.StockName} price changed to {e.Price}");
    }
}


// ==========================================
// 3. Comparison
// ==========================================

/*
Custom Observer Interface:
- We manually maintain a list of observers.
- We manually call Update() on every observer.
- Subscribe and Unsubscribe methods are explicitly implemented.
- More control, but more code.

C# Events:
- C# manages the subscriber list internally.
- Subscribers use += to subscribe and -= to unsubscribe.
- The event publisher invokes the event.
- Less boilerplate and idiomatic C#.

Both approaches implement the Observer pattern:
one object (StockTicker) notifies multiple subscribers
when its state changes.
*/