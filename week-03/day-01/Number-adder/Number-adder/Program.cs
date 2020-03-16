using System;

namespace Number_adder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a recursive function that takes one parameter: n and adds numbers from 1 to n.
            int x = BlackAdder(5);
            Console.WriteLine(x);

        }

        public static int BlackAdder(int n)
        {
            //int result = 0;
            if (n == 1)
            {
                return 1;
            }
            return n + BlackAdder(n - 1);
        }
    }
}
