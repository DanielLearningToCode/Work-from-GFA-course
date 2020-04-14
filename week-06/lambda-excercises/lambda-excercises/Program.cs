using System;
using System.Collections.Generic;
using System.Linq;

namespace lambda_excercises
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Exercise 1
            //Write a LINQ Expression to get the even numbers from the following array:
            //int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            //var evenNumbers = n.Where(p => p % 2 == 0);
            //foreach (var num in evenNumbers)
            //{
            //    Console.Write(num + ", ");
            //}

            //Exercise 2
            //Write a LINQ Expression to get the average value of the odd numbers
            //from the following array:
            //int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            //var averageOfOddNumbers = n.Where(p => p % 2 != 0).Sum() / n.Where(p => p % 2 != 0).Count();
            //Console.WriteLine(averageOfOddNumbers);

            //Exercise 3
            //Write a LINQ Expression to get the squared value of the positive
            //numbers from the following array:
            //int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            //var positiveNumbersSquared = n.Where(p => p > 0).Select(n => n*n);
            //foreach (var num in positiveNumbersSquared)
            //{
            //    Console.WriteLine(num);
            //}
            //

            //Exercise 4
            //Write a LINQ Expression to find which number squared value is more
            //then 20 from the following array:
            //int[] n = new[] { 3, 9, 2, 8, 6, 5 };
            //var numbersSquaredOverTwenty = n.Where(p => p * p > 20);
            //numbersSquaredOverTwenty.ToList().ForEach(Console.WriteLine);

            //Exercise 5
            //Write a LINQ Expression to find the frequency of numbers in the following array:
            int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            // Dictionary<int,int> dict = n.Where()
            var freqList = n.GroupBy(p => p);//.Select(p => new { p.Key, count = p.Count() });
            foreach (var item in freqList)
            {
                Console.WriteLine(item.Key + " "+ item.Count());    
            }
        }
    }
}
