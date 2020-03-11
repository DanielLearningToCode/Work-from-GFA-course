using System;
using System.IO;

namespace WriteSingleLine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that is able to manipulate a file
            // By writing your name into it as a single line
            // The file should be named "my-file.txt"
            // In case the program is unable to write the file,
            // It should print the following error message: "Unable to write file: my-file.txt"

            WriteLine("Dan");
        }
        public static void WriteLine(string text)
        {
            try
            {
                StreamWriter writer = new StreamWriter("my-file.txt", append: true) ;
                writer.WriteLine(text);
                writer.Dispose();
            }
            catch (IOException)
            {
                Console.WriteLine("Unable to write file: my - file.txt");
            }
        }

    }
}
