using System;

namespace AnimalsAndLegs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The second represents the number of pigs owned by the farmer
            // It should print how many legs all the animals have

            Console.WriteLine("How many chickens are there?");
            int chickens = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many pigs are there?");
            int pigs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(pigs * 4 + chickens * 2);
            Console.ReadLine();
        }
    }
}
