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
            
            purchases.Add((ticker: "GM", shares: 150, price: 23.21));
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

            foreach ((string ticker, int shares, double price) purchase in purchases){
                if(stocks.ContainsKey(purchase.ticker))
                {
                    if(purchaseInfo.ContainsKey(purchase.ticker))
                    {
                        purchaseInfo[stocks[purchase.ticker]] += purchase.shares * purchase.price;
                    }
                    else
                    {
                        purchaseInfo[stocks[purchase.ticker]] = purchase.shares * purchase.price;
                    }
                }
            }

            foreach (KeyValuePair<string, double> t in purchaseInfo)
            {
                Console.WriteLine($"{t.Key} {t.Value:C}");
            }

            // Iterate over the purchases and 
            // foreach ((string ticker, int shares, double price) purchase in purchases)
            // {
            //     if (purchaseInfo.ContainsKey(purchase.ticker)){
            //         Console.WriteLine(purchase.ticker);
            //         purchaseInfo[purchase.ticker] += (purchase.price * Convert.ToDouble(purchase.shares));
            //         Console.WriteLine(purchaseInfo[purchase.ticker]);
            //     }
            //     else
            //     {
            //         purchaseInfo[purchase.ticker] = (purchase.price * Convert.ToDouble(purchase.shares));
            //         Console.WriteLine(purchase);
            //     }
            // }
        }
    }
}
