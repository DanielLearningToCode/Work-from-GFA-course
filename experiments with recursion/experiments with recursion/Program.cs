using System;

namespace experiments_with_recursion
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = "text";
            Console.WriteLine(str.Substring(2, str.Length- 2)); 
            //Console.WriteLine(Strings("This text contains lot of xxx characters"));
        }

        public static string Strings(string str)
        {
            //Given a string, compute recursively(no loops) a new string where all the lowercase 'x' chars have been changed to 'y' chars.
            if (str.Length == 0) return "";
            if (str[0].Equals('x')) return "y" + Strings(str.Substring(1, str.Length - 1));
            else return str[0] + Strings(str.Substring(1, str.Length - 1));
        }
    }
}
