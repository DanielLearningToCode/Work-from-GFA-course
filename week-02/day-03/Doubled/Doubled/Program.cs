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
            string text = File.ReadAllText("file.txt");

            text = text.Replace('\r', '\n');

            string decodedText = "";

            for (int i = 0; i < text.Length; i += 2)
            {
                decodedText += text[i];
            }

            Console.WriteLine(decodedText);

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
