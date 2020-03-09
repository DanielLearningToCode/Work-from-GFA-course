using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a function called `Factorio`
            //   that returns it's input's factorial
            int input = UserInput();
            int result = Factorial(input);
            Console.WriteLine(result);

            Console.ReadLine();
        }

        public static int Factorial(int number)
        {
            int num = 1;
            for (int i = number; i > 0; i--)
            {
                num *= i;
            }
            return num;

        }

        public static int UserInput()
        {
            Console.WriteLine("Enter the range");
            int.TryParse(Console.ReadLine(), out int input);
            return input;
        }
    }
}
