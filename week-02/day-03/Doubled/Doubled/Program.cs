using System;
using System.IO;
using System.Collections.Generic;

namespace Doubled
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method that decrypts the duplicated-chars.txt 
            string text = File.ReadAllText("TextFile1.txt");
            text = text.Replace("\r", "\n");
            char[] arrayOfChars = text.ToCharArray();
            string decodedText = "";

            for (int i = 0; i < arrayOfChars.Length; i += 2)
            {
                decodedText += arrayOfChars[i];
            }
            Console.Write(decodedText);
            Console.WriteLine();

            /*// alternative - removes all double letters, including the correct ones 

            char readChar = '\0';
            char previousChar = arrayOfChars[0];

            foreach (var item in arrayOfChars)
            {
                readChar = item;
                if (readChar != previousChar)
                {
                    decodedText += readChar;
                }
                previousChar = readChar;

            }
            Console.WriteLine(decodedText);*/

        }
    }
}
