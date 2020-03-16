using System;

namespace sum_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a non-negative integer n, return the sum of its digits recursively (without loops).

            Console.WriteLine("Enter a number the digits of which you want to add together: ");
            string givenNumber = Console.ReadLine();
            Console.WriteLine(SumDigits(givenNumber));
            Console.ReadLine();

        }

        public static int SumDigits(string givenNumber)
        {
            if (givenNumber.Length == 1)
            {
                return Convert.ToInt32(givenNumber);
            }
            return Convert.ToInt32(givenNumber[givenNumber.Length-1].ToString()) + SumDigits(givenNumber.Substring(0, givenNumber.Length-1));
        }

        /*public static int SumDigits(int n)
        {
            int numOfDigits = n.ToString().Length;
            if (numOfDigits == 1)
            {
                return n % 10;
            }
            
            return 
        }
*/    }
}
