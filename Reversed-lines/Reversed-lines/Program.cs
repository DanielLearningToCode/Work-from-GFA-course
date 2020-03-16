using System;
using System.IO;
using System.Linq;

namespace Reversed_lines
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string[] encodedLines = File.ReadAllLines("source.txt");
            
            string decodedText = "";
            for (int i = 0; i < encodedLines.Length; i++)
            {
                char[] tempArray = encodedLines[i].ToCharArray();
                Array.Reverse(tempArray);
                decodedText += string.Join("",tempArray) + "\n";
            }
            Console.WriteLine(decodedText);*/

            // another method
            //Console.WriteLine(MyReverse()); 

            // yet another = reading string backwards
            StreamReader reader = new StreamReader("source.txt");
            string line = reader.ReadLine();
            string decodedText = "";
            while (line != null)
            {
                string reversedLine = "";
                // reverse one line by reading it backwards
                for (int i = line.Length - 1; i >= 0; i--)  
                {
                    reversedLine += line[i];
                }
                decodedText += reversedLine + "\n";
                line = reader.ReadLine();
            }
            reader.Close();
            Console.WriteLine(decodedText);
        }

    /*    private static string MyReverse()
        {
            StreamReader reader = new StreamReader("source.txt");
            string line = reader.ReadLine();
            string decodedText = "";
            while (line != null)
            {
                char[] tempArray = line.ToCharArray();
                Array.Reverse(tempArray);
                decodedText += String.Join("", tempArray) +"\n";
                line = reader.ReadLine();
            }
            reader.Close();
            return new string(decodedText);
        }*/
    }
}
