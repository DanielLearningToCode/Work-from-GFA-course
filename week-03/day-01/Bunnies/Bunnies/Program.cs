using System;

namespace Bunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            // We have a number of bunnies and each bunny has two big floppy ears.
            // We want to compute the total number of ears across all the bunnies recursively
            // (without loops or multiplication).
            Console.WriteLine("Enter the number of bunnies: ");
            int numberOfBunnies = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CountEars(numberOfBunnies)); 
        }

        private static int CountEars(int numberOfBunnies)
        {
            if (numberOfBunnies < 1)
            {
                throw new ArgumentOutOfRangeException ("Enter positive integers only");
            }
            else
            {
                if (numberOfBunnies == 1)
                {
                    return 2;
                }
                return 2 + CountEars(numberOfBunnies - 1);
            }
        }

    }
}
