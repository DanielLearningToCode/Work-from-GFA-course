using System;

namespace Strings_again_and_again
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Given a string, compute recursively a new string where all the adjacent
            ///chars are now separated by a *
            ///
            Console.WriteLine("Enter a string");
            string text = Console.ReadLine();
            Console.WriteLine(Separate(text)); 
        }

        private static string Separate(string text)
        {
            if (text.Length == 1)
            {
                if (text != " ")
                {
                    return text + "*";
                }
                else
                {
                    return text;
                }
            }
            else
            {
                string firstHalf = text.Substring(0, text.Length / 2);
                string secondHalf = text.Substring(text.Length / 2);
                return "" + Separate(firstHalf) + Separate(secondHalf);
            }
            
        }
    }
}
