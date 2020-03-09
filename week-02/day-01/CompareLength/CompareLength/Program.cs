using System;

namespace CompareLength
{
    class Program
    {
        static void Main(string[] args)
        {

            // - Create an array variable named `p1`
            //   with the following content: `[1, 2, 3]`
            // - Create an array variable named `p2`
            //   with the following content: `[4, 5]`
            // - Print "p2 is longer" if `p2` has more elements than `p1`
            int[] p1 = { 1, 2, 3 };
            int[] p2 = { 4, 5 };

            if (p2.Length > p1.Length)
            {
                Console.WriteLine("p2 is longer.");
            }

            Console.ReadLine();
        }
    }
}
