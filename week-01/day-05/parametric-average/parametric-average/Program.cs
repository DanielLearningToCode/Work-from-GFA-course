using System;

namespace parametric_average
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a number.
            // It would ask this many times to enter an integer,
            // if all the integers are entered, it should print the sum and average of these
            // integers like:
            //
            // Sum: 22, Average: 4.4

            bool isNumber = false;
            int howManyNumbers = 0;
            int enteredNumber;
            double sum = 0;

            while (!isNumber) {
                Console.WriteLine("Enter how many numbers you want to enter: ");
                isNumber = int.TryParse(Console.ReadLine(), out howManyNumbers);
                if (isNumber)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("whole numbers only");
                }
            }
            for(int i = 0; i < howManyNumbers; i++)
            {
                while (true)
                {
                    Console.WriteLine($"Enter the {i + 1}. number: ");
                    isNumber = int.TryParse(Console.ReadLine(), out enteredNumber);
                    if (isNumber)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter only numbers.");
                    }
                }

                sum += enteredNumber;
            }
            double average = sum / howManyNumbers;
            Console.WriteLine($"sum: {sum}");
            Console.WriteLine($"average: {average}");




        }
    }
}
