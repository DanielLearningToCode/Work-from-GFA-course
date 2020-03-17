using System;

namespace Strings_again
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Given a string, compute recursively a new string where all 
            ///the 'x' chars have been removed.
            ///
            Console.WriteLine("Enter a string");
            string text = Console.ReadLine();

            Console.WriteLine(RemoveX(text)) ;
        }

        private static string RemoveX(string text)
        {
            if (text.Length == 1)
            {
                if (text.ToLower() == "x")
                {
                    return "";
                }
                else
                {
                    return text;
                }
            }
            else
            {
                string firstHalf = text.Substring(0,text.Length/2);
                string secondHalf = text.Substring(text.Length / 2);
                return "" + RemoveX(firstHalf) + RemoveX(secondHalf); 
            }
        }
    }
}
