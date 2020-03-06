using System;

namespace Excercises_Friday
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculator
            // Create a very simplistic calculator: ask for two numbers and an operation (add, subtract, multiply or divide)
            // Based on the operation provided print the result of the calculation.


            string quit = null;

            while (quit != "quit")
            {
                try
                {
                    // Get the first number
                    Console.WriteLine("Welcome to the Calculator!");
                    Console.WriteLine("Please provide the first number:");
                    double number1 = Convert.ToInt32(Console.ReadLine());

                    // Get the second number
                    Console.WriteLine("Please provide the second number:");
                    double number2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Please provide the operation (1 - add, 2 - subtract, 3 - multiply, 4 - divide):");

                    // Get the operation from standard input:
                    string operation = Console.ReadLine();

                    // use the `switch` statement and the corresponding calculation
                    // store the result of the calculation in the `result` variable
                    double result = 0.0;

                    switch (operation)
                    {
                        case "1":
                        case "add":
                            result = number1 + number2;
                            break;

                        case "2":
                        case "subtract":
                            result = number1 - number2;
                            break;

                        case "3":
                        case "multiply":
                            result = number1 * number2;
                            break;

                        case "4":
                        case "divide":
                            result = number1 / number2;
                            break;

                        default:
                            Console.WriteLine("Please enter correct operation");
                            break;

                    }

                    Console.WriteLine($"The result of the calculation is {result}");
                    Console.WriteLine();
                    Console.WriteLine("If you want to quit, type in \"quit\", otherwise hit enter");
                    quit = Console.ReadLine();

                }
                catch (Exception)
                {

                    Console.WriteLine("Please mind the inputs.");
                    Console.WriteLine();
                }
            }
        }
    }
}
