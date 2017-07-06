using System;
using System.Collections.Generic;

namespace transactionTuples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();

            transactions.Add(("car", 22000, 3));
            transactions.Add(("moped", 12000, 34));
            transactions.Add(("bike", 200, 63));

            double totalSales = 0;
            int totalItems = 0;
            foreach ((string product, double amount, int quantity) t in transactions)
            {
                totalSales += t.Item2;
                totalItems += t.Item3;
            }
            
            Console.WriteLine("Items sold today: " + totalItems);
            Console.WriteLine($"Total revenue: {totalSales:C}");
        }
    }
}
