using System;

namespace GreatesCommonDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int n1, n2;
                Console.WriteLine("Enter a positive integer: ");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second positive integer: ");
                n2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(HighestCommonFactor(n1,n2));
                
            }
        // variant of Euclid's algorithm = black magic 
        }
        public static int HighestCommonFactor(int n1, int n2)
        {
            if (n2 != 0)
                return HighestCommonFactor(n2, n1 % n2);
            else
                return n1;
        }
        /*
                private static int FindDivisor(int biggerNumber, int smallerNumber)
                {
                    if (biggerNumber % smallerNumber == 0)
                    {
                        return smallerNumber;
                    }

                }*/
    }
}
