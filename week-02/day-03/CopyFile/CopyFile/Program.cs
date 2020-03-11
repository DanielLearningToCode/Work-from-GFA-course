using System;
using System.IO;
namespace CopyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a function that reads all lines of a file and writes the read lines to an other file (a.k.a copies 
            // the file)
            // It should take the filenames as parameters
            // It should return a boolean that shows if the copy was successful
            if (CopyCat("TextFile1.txt", "file2.txt"))
            {
                Console.WriteLine("copy successful");
            }
            else
            {
                Console.WriteLine("copy failed");
            }
            ;

        }
        public static bool CopyCat(string readFile,string writtenFile)
        {
            bool success = true;
            try {
                using (StreamReader reader = new StreamReader(readFile))
                {
                    using (StreamWriter writer = new StreamWriter(writtenFile))
                    {
                        string line = string.Empty;
                        while (line != null)
                        {
                            line = reader.ReadLine();
                            writer.WriteLine(line);
                        }
                    }
                }
            }
            catch (IOException)
            {
                success = false;
            }

            return success;
        }
    }
}
