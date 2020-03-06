using System;

namespace count_from_to
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that asks for two numbers
            // If the second number is not bigger than the first one it should print:
            // "The second number should be bigger"
            //
            // If it is bigger it should count from the first number to the second by one
            //
            // example:
            //
            // first number: 3, second number: 6, should print:
            //
            // 3
            // 4
            // 5

            Console.WriteLine("Please enter the first number: ");
            bool isNumber = Int32.TryParse(Console.ReadLine(), out int num1);

            while (true)
            {
                if (!isNumber)
                {
                    Console.WriteLine("numbers only");
                    return;

                }


                Console.WriteLine("Please enter the second number: ");
                isNumber = Int32.TryParse(Console.ReadLine(), out int num2);
                if (!isNumber)
                {
                    Console.WriteLine("numbers only");
                    return;
                }

                if (num1 >= num2)
                {
                    Console.WriteLine("The second number should be bigger");
                }
                else
                {
                    for (int i = num1; i < num2; i++)
                    {
                        Console.WriteLine(i);
                    }

                } 
            }



        }
    }
}
