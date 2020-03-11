using System;
using System.IO;
using System.Collections.Generic;

namespace PrintEachLine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that opens a file called "my-file.txt", then prints
            // each line from the file.
            // If the program is unable to read the file (for example it does not exist),
            // then it should print the following error message: "Unable to read file: my-file.txt"

            string[] text = null;
            try
            {
                text = File.ReadAllLines("my-file.txt");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Unable to read file: my-file.txt");
            }

            try
            {
                foreach (var item in text)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
