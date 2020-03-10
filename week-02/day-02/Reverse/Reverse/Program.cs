using System;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            // Create a method that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!

            Console.WriteLine(Reversed(reversed));
        }
        public static string Reversed(string sentence)
        {
            char[] letters = sentence.ToCharArray();
            Array.Reverse(letters);
            sentence = String.Join("", letters);
            return sentence;
        }

    }
}
