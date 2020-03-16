using System;

namespace Find_a_substring
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a function that takes two strings as a parameter
            //  Returns the starting index where the second one is starting in the first one
            //  Returns `-1` if the second string is not in the first one

            //  Example:

            //  should print: `17`
            //long varinat
            Console.WriteLine(Substr("this is what I'm searching in", "searching"));

            //  should print: `-1`
            Console.WriteLine(Substr("this is what I'm searching in", "not"));

            string mytext = "this is what I'm searching in";
            string search = "not";
            // short variant
            Console.WriteLine(mytext.IndexOf(search));


        }
        private static int Substr(string text, string searchedString)
        {
            bool found = text.Contains(searchedString);
            int index;
            if (found)
            {
                index = text.IndexOf(searchedString);
            }
            else
            {
                index = -1;
            }
            return index;
        }

    }

   
}

