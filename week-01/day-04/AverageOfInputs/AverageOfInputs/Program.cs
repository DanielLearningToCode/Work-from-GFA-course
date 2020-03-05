using System;

namespace AverageOfInputs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4

            Console.WriteLine("Enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number: ");
            int e = Convert.ToInt32(Console.ReadLine());

            int sum = a + b + c + d + e;
            double average = sum / 5.0;
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + average);
            Console.ReadLine();

        }
    }
}
