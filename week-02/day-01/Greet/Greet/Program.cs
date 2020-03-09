using System;

namespace Greet
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a string variable named `al` and assign the value `Green Fox` to it
            // - Create a function called `Greet` that greets it's input parameter
            //     - Greeting is printing e.g. `Greetings dear, Green Fox`
            // - Greet `al`

            string al = "Green Fox";
            Greet(al);
        }

        public static void Greet(string name)
        {
            Console.WriteLine($"Greetings dear {name}");
        }
    }
}
