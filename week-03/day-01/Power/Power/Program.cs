using System;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Given base and n that are both 1 or more, compute recursively (no loops) 
            ///the value of base to the n power, so powerN(3, 2) is 9 (3 squared).
            ///
            Console.WriteLine("Enter the number you raise to a power");
            int baseNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the power: ");
            int exponent = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(PowerRecursively(baseNum, exponent));
        }

        private static int PowerRecursively(int baseNum, int exponent)
        {
            if (exponent == 1)
            {
                return baseNum;
            }
            return baseNum * PowerRecursively(baseNum, exponent - 1);
        }
    }
}
