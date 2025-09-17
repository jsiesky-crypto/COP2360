// Stock.cs
// Demonstrates: automatic properties, expression-bodied properties, 
// method overloading, and object initializers

using System;

public class Stock
{
    // Automatic properties
    public decimal CurrentPrice { get; set; }
    public int SharesOwned { get; set; }

    // Expression-bodied read-only property
    public decimal Worth => CurrentPrice * SharesOwned;

    // Overloaded methods
    public void PrintSummary()
    {
        Console.WriteLine($"Shares: {SharesOwned}, Price: {CurrentPrice:C}, Worth: {Worth:C}");
    }

    public void PrintSummary(string label)
    {
        Console.WriteLine($"{label} -> Shares: {SharesOwned}, Price: {CurrentPrice:C}, Worth: {Worth:C}");
    }
}

public static class Program
{
    public static void Main()
    {
        // Using object initializer
        Stock s1 = new Stock { CurrentPrice = 50.25M, SharesOwned = 100 };
        s1.PrintSummary();
        s1.PrintSummary("Portfolio A");

        // Using constructor-style initialization for comparison
        Stock s2 = new Stock();
        s2.CurrentPrice = 120.10M;
        s2.SharesOwned = 50;
        s2.PrintSummary("Portfolio B");
    }
}
