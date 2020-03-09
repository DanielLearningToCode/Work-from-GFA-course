using System;

namespace Summing
{
    class Program
    {
       
        static void Main(string[] args)
        {
            // Write a function called `sum` that returns the sum of numbers from zero to the given parameter
            int range = UserInput();
            int sum = Sum(range);
            Console.WriteLine($"The sum of {range} is: {sum}");

        }


        public static int Sum (int range)
        {
            int sum = 0;
            for (int i = 0; i <= range; i++)
            {
                sum += i;
            }
            return sum;
        }
        public static int UserInput()
        {
            Console.WriteLine("Enter the range");
            int.TryParse(Console.ReadLine(), out int input);
            return input;
        }

    }
}
