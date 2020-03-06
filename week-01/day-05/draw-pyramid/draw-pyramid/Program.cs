using System;

namespace draw_pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // pyramid like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //
            // The pyramid should have as many lines as the number was

            Console.WriteLine("Enter the number of lines: ");
            int numberOfLines = Convert.ToInt32(Console.ReadLine());

            //constant values
            int lengthOfTheLastLine = (numberOfLines -1) * 2 +1;  
            int middleOfTheLine = (lengthOfTheLastLine / 2) + 1;
            
            // changing values
            int indentation = middleOfTheLine -1 ;  // length of indentation = number of spaces
            int charsOnCurrentLine = lengthOfTheLastLine - indentation * 2;  


            for (int line = 1; line <= numberOfLines; line++)   // lines
            {

                for (int i = 0; i < indentation; i++)     //spaces on a line = indentation
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < charsOnCurrentLine; i++)  // asterisks on a line
                {
                    Console.Write("*");
                }
                
                Console.WriteLine("");      // new line when you finish one line
                
                indentation -= 1;
                charsOnCurrentLine += 2;
            }
        }
    }
}
