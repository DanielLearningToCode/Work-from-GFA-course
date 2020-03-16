using System;

namespace sum_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a non-negative integer n, return the sum of its digits recursively (without loops).
            Console.WriteLine("Enter a number the digits of which you want to add together: ");
            int givenNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(SumDigits(givenNumber));
            Console.ReadLine();
        }

        public static int SumDigits(int number)
        {
            if (number < 10)
            {
                return number;
            }
            return number % 10 + SumDigits(number / 10);
        }

        // an unnecessaryly complicated alternative using modulo operator
       /* public static int SumDigits(int n)
        {
            double numOfDigits = n.ToString().Length;
            if (numOfDigits == 1)
            {
                return n;
            }
            return n / Convert.ToInt32(Math.Pow(10, numOfDigits - 1))
                + SumDigits(n % Convert.ToInt32(Math.Pow(10, numOfDigits - 1)));
        }*/
        // alternative using string manipulation
        /*        public static int SumDigits(string givenNumber)
                {
                    if (givenNumber.Length == 1)
                    {
                        return Convert.ToInt32(givenNumber);
                    }
                    return Convert.ToInt32(givenNumber[givenNumber.Length-1].ToString()) + SumDigits(givenNumber.Substring(0, givenNumber.Length-1));
                }*/
    }
}
