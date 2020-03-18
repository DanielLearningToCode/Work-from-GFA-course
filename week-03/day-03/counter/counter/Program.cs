using System;

namespace counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter myCounter = new Counter();
            myCounter.Add();
            Console.WriteLine(myCounter.Get());
            myCounter.Add(5);
            Console.WriteLine(myCounter.Count);
            Console.WriteLine(myCounter.Get()) ;
            myCounter.Reset();
            Console.WriteLine(myCounter.Get());

            Counter secondCounter = new Counter(10);
            Console.WriteLine(secondCounter.Get()); 

        }
    }
}
