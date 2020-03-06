using System;

namespace guess_the_number
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores a number, and the user has to figure it out.
            // The user can input guesses, after each guess the program would tell one
            // of the following:
            //
            // The stored number is higher
            // The stried number is lower
            // You found the number: 8

            int guess = 0;
            int number = 8;
            bool isNumber;

            // input with data validation
            while (guess != number)
            {
                Console.WriteLine("Enter your guess: ");
                isNumber = int.TryParse(Console.ReadLine(), out guess);

                if (isNumber)
                {
                    // comparison
                    if (guess < number)
                    {
                        Console.WriteLine("The stored number is higher");
                    }

                    else if (guess > number)
                    {
                        Console.WriteLine("The stored number is lower");
                    }

                    else
                    {
                        Console.WriteLine("You found the number: 8");
                    }
                }
                else
                {
                    Console.WriteLine("Whole numbers only");
                }

                


            }

              

        }
    }
}
