using System;

namespace aircraft_carrier
{
    class Program
    {
        static void Main(string[] args)
        {
            F16 one = new F16();
            Console.WriteLine(one.GetStatus());
            Console.WriteLine(one.GetType());
            Console.WriteLine(one.IsPriority());
            Console.WriteLine(one.Fight());
            Console.WriteLine(one.Refill(10));
            Console.WriteLine(one.Fight());
            Console.WriteLine(one.GetStatus());
            Console.WriteLine();
            F35 two = new F35();
            Console.WriteLine(two.GetStatus());
            Console.WriteLine(two.GetType());
            Console.WriteLine(two.IsPriority());
            Console.WriteLine(two.Fight());
            Console.WriteLine(two.Refill(10));
            Console.WriteLine(two.Fight());
            Console.WriteLine(two.GetStatus());

        }
    }
}
