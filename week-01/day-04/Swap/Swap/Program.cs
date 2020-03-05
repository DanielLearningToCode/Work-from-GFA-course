using System;

namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            // Swap the values of the variables
            int a = 123;
            int b = 526;

            int pomocna = a;
            a = b;
            b = pomocna;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            
        }
    }
}
