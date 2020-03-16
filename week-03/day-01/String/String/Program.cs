using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Given a string, compute recursively(no loops) a new string where all
            ///the lowercase 'x' chars have been changed to 'y' chars.

            Console.WriteLine("Enter a string");
            string text = Console.ReadLine();
            Console.WriteLine(ReplaceX(text));
        }
        public static string ReplaceX(string text)
        {
            if (text.Length == 1)
            {
                if (text == "x")
                {
                    return "y";
                }
                else
                {
                    return text;
                }
            }
            else
            {
                string firstHalf = text.Substring(0,text.Length/2);
                string secondHalf = text.Substring(text.Length/2);
                return "" + ReplaceX(firstHalf) + ReplaceX(secondHalf);
            }
        }

        // iteratively 
        /*private static string ReplaceX(string originalText)
        {
            string processedText = "";
            for (int i = 0; i < originalText.Length; i++)
            {
                if (originalText[i] == 'x')
                {
                    processedText += 'y';
                }
                else
                {
                    processedText += originalText[i];
                }
            }
            return processedText;
        }
*/    }
}
