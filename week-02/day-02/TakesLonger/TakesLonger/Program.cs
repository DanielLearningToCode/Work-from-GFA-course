using System;
using System.Text;
using System.Collections.Generic;
namespace TakesLonger
{
    class Program
    {
        static void Main(string[] args)
        {
            string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";

            // When saving this quote a disk error has occured. Please fix it.
            // Add "always takes longer than" to the StringBuilder (quote) between the words "It" and "you"
            // Using pieces of the quote variable (instead of just redefining the string)


            //
            //using stringBuilder
            StringBuilder sentence = new StringBuilder(quote);
            sentence.Insert(20, " always takes longer than");
            quote = sentence.ToString();
            Console.WriteLine(quote);

            /*string[] array = quote.Split(" ");
            List <string> list = new List <string> (array);

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == "It")
                {
                    list.Insert(i+1,"always takes longer than");
                }
            }
            quote = String.Join(" ", list);
            Console.WriteLine(quote);
*/
        }
    }
}
