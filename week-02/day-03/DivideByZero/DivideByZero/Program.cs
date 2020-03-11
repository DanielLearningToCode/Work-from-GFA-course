using System;

namespace DivideByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes a number
            // divides ten with it,
            // and prints the result.
            // It should print "fail" if the parameter is 0

            DivideTen();
        }

        public static void DivideTen()
        {
            bool isNumber = false; 
            int number = 0;
            do
            {
                Console.WriteLine("Please enter a whole number as a divisor: ");
                isNumber = Int32.TryParse(Console.ReadLine(), out number);

            } while (!isNumber);

            try
            {
                Console.WriteLine(10 / number);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Fail");
            }
        }
    }
}

