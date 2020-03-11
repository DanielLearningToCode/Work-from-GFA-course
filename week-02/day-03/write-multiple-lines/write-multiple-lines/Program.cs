using System;
using System.IO;
namespace write_multiple_lines
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes 3 parameters: a path, a word and a number
            // and is able to write into a file.
            // The path parameter should be a string that describes the location of the file you wish to modify
            // The word parameter should also be a string that will be written to the file as individual lines
            // The number parameter should describe how many lines the file should have.
            // If the word is 'apple' and the number is 5, it should write 5 lines
            // into the file and each line should read 'apple'
            // The function should not raise any errors if it could not write the file.
            WriteLines(Console.ReadLine(), "apple", 5); 

        }
        public static void WriteLines (string path, string word, int numberOfLines)
        {
            try
            {
                StreamWriter writer = new StreamWriter(path);
                for (int i = 0; i < numberOfLines; i++)
                {
                    writer.WriteLine(word);
                }
                writer.Dispose();
            }
            catch (Exception)
            {
                Console.WriteLine("an error occured");
            }
        }

    }
}
