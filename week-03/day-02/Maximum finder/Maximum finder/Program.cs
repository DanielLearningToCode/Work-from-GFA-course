using System;

namespace Maximum_finder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a function that finds the largest element of an array using recursion.

            int[] arrayOfNumbers = { 987, 0, 45, 66, 78, 78, 45, 78, 98, 9, 0, 7, 4 };
            Console.WriteLine(findMaxNumber(arrayOfNumbers));
        }
        private static int findMaxNumber(int[] arrayOfNumbers)
        {// base case: if the array has two numbers, return the bigger one 
            if (arrayOfNumbers.Length == 2)
            {
                if (arrayOfNumbers[0] < arrayOfNumbers[1])
                {
                    return arrayOfNumbers[1];
                }
                else
                {
                    return arrayOfNumbers[0];
                }
            }
            else if (arrayOfNumbers.Length == 1){
                return arrayOfNumbers[0];
            }
            else  // otherwise split the array into two subarrays and repeat
            {
                int[] firstHalf = arrayOfNumbers[0..Convert.ToInt32(arrayOfNumbers.Length / 2)];
                int[] secondHalf = arrayOfNumbers[Convert.ToInt32(arrayOfNumbers.Length / 2)..arrayOfNumbers.Length];
                var num1 = findMaxNumber(firstHalf);
                var num2 = findMaxNumber(secondHalf);
                if (num1 > num2)
                {
                    return num1;
                }
                else
                {
                    return num2;
                }
            }
        }
    }
}
