using System;
using System.Collections.Generic;
using System.Linq;

namespace linqList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() {"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"};

            IEnumerable<string> LFruits = 
                from x in fruits
                where x.StartsWith("L") 
                select x;

            foreach(string x in LFruits)
            {
                Console.WriteLine(x);
            }

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            var fourSixMultiples = numbers.Where(t => t % 4 = 0);



            
        }
    }
}
