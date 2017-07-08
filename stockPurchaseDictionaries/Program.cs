using System;
using System.Collections.Generic;

namespace stockPurchaseDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("AAPL", "Apple");
            stocks.Add("AMZN", "Amazon");
            stocks.Add("SBUX", "Starbucks");

            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();
            
            purchases.Add((ticker: "GE", shares: 150, price: 23.21));
            purchases.Add((ticker: "CAT", shares: 340, price: 90.21));
            purchases.Add((ticker: "AAPL", shares: 450, price: 5523.21));
            purchases.Add((ticker: "AMZN", shares: 750, price: 9545.21));
            purchases.Add((ticker: "SBUX", shares: 150, price: 2345.21));
            purchases.Add((ticker: "SBUX", shares: 150, price: 2345.21));

            /* 
                Define a new Dictionary to hold the aggregated purchase information.
                - The key should be a string that is the full company name.
                - The value will be the valuation of each stock (price*amount)

                {
                    "General Electric": 35900,
                    "AAPL": 8445,
                    ...
                }
            */
            Dictionary<string, double> purchaseInfo = new Dictionary<string, double>();

            // Iterate over the purchases and 
            foreach ((string ticker, int shares, double price) purchase in purchases)
            {
                if (purchaseInfo.ContainsKey(purchase.ticker)){
                    Console.WriteLine(purchase.ticker);
                    purchaseInfo[purchase.ticker] += (purchase.price * Convert.ToDouble(purchase.shares));
                    Console.WriteLine(purchaseInfo[purchase.ticker]);
                }
                else
                {
                    purchaseInfo[purchase.ticker] = (purchase.price * Convert.ToDouble(purchase.shares));
                    Console.WriteLine(purchase);
                }
            }

            foreach (KeyValuePair<string, string> stock in stocks)
            {
                foreach (KeyValuePair<string, double> purchase in purchaseInfo)
                {
                    if(stock.Key == purchase.Key)
                    {
                        // Console.WriteLine(stock.Value);
                        // Console.WriteLine(purchase.Key);
                        purchase.Key = stock.Value;
                    }
                }
            }

            // foreach ((string ticker, int shares, double price) purchase in purchases)
            // {
            //     try
            //     {

            //         purchaseInfo.Add(purchase.ticker, (purchase.price * Convert.ToDouble(purchase.shares)));
            //     }
            //     catch
            //     {
            //         purchaseInfo[purchase.ticker] += (purchase.price * Convert.ToDouble(purchase.shares));
            //     }
            // }

            foreach (KeyValuePair<string, double> t in purchaseInfo)
            {
                Console.WriteLine(t);
            }
        }
    }
}
