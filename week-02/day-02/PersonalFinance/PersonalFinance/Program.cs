using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonalFinance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a list with the following items.

            //500, 1000, 1250, 175, 800 and 120
            List<int> spendingsList = new List<int>() { 500, 1000, 1250, 175, 800, 120 };

            /*Create an application which solves the following problems.
            // How much did we spend? */
            // spendingsList.Sum();  // lazy method

            int sum = 0;
            int greatestExpense = 0;
            int cheapestSpening = spendingsList[0]; ;
            int average = 0;

            for (int i = 0; i < spendingsList.Count; i ++)
            {
                sum += spendingsList[i];
                
                // finding the most expensive one 
                if (spendingsList[i] > greatestExpense)
                {
                    greatestExpense = spendingsList[i];
                }

                // finding the smallest one
                
                if (spendingsList[i] < cheapestSpening)
                {
                    cheapestSpening = spendingsList[i];
                }

            }
            average = sum / spendingsList.Count;
            Console.WriteLine("The sum is {0:C}", sum);
            Console.WriteLine("The greatest expense was {0:C}", greatestExpense);
            Console.WriteLine("The cheapest expense was {0:C} ", cheapestSpening);
            Console.WriteLine("The average spending was {0:C}", average);
        }
    }
}
