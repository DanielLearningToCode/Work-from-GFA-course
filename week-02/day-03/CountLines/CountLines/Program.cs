using System;
using System.IO;

namespace CountLines
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that takes a filename as string,
            // then returns the number of lines the file contains.
            // It should return zero if it can't open the file, and
            // should not raise any error.

            Console.WriteLine(NumberOfLines()); ;
        }
        public static int NumberOfLines()
        {
            Console.WriteLine("Enter the file name");
            try
            {
                string fileName = Console.ReadLine();
                int lineCount = File.ReadAllLines(fileName).Length;
                return lineCount;
            }
            catch (FileNotFoundException)
            {
                return 0;
                
            }
            catch (IOException)
            {
                return 0;
            }
            
        }

    }
}
