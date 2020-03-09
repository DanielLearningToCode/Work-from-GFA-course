using System;

namespace SwapElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `abc`
            //   with the following content: `["first", "second", "third"]`
            // - Swap the first and the third element of `abc`
            string[] abc = {"first", "second", "third"};

            string temp = abc[0];
            abc[0] = abc[abc.Length - 1];
            abc[abc.Length - 1] = temp;

            Console.WriteLine(abc[0] + ", " + abc [1] + ", " + abc[2]);
            Console.ReadLine();
        }
    }
}
