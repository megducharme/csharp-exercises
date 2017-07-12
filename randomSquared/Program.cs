using System;
using System.Collections.Generic;

namespace randomSquared
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNums = new Random();

            //make a list of 50 random numbers
            List<int> randomNumList = new List<int>();
            for(int i = 0; i < 50; i++ )
            {
                randomNumList.Add(randomNums.Next(0,50));
            }

            //now, square them and store them in another list
            List<int> randomSquared = new List<int>();
            foreach(int num in randomNumList)
            {
                randomSquared.Add(num * num);
            }

            //remove the odd numbers
            List<int> randomSquaredEven = new List<int>();
            
            foreach(int num in randomSquared)
            {
                if(num % 2 == 0)
                {
                    randomSquaredEven.Add(num);
                }
            }

            //printing them to the console to make sure I did it right (spoiler alert: I did!)
            foreach(int num in randomSquaredEven)
            {
                Console.WriteLine(num);
            }
        }
    }
}
