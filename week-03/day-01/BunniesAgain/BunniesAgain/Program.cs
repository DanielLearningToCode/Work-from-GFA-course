using System;

namespace BunniesAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            /// We have bunnies standing in a line, numbered 1, 2, ... The odd bunnies(1, 3, ..)
            /// have the normal 2 ears.The even bunnies(2, 4, ..) we'll say have 3 ears, because 
            /// they each have a raised foot. Recursively return the number of "ears" in the bunny 
            /// line 1, 2, ... n (without loops or multiplication).
            Console.WriteLine("Enter the number of bunnies. Postive integers only");
            int numberOfBunnies = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CountEars(numberOfBunnies));
        }

        private static int CountEars(int numberOfBunnies)
        {
            if (numberOfBunnies < 1)
            {
                return 0;
            }
            else if (numberOfBunnies % 2 != 0)
            {
                return 2 + CountEars(numberOfBunnies - 1);
            }
            else
            {
                return 3 + CountEars(numberOfBunnies - 1);
            }
        }
    }
}
