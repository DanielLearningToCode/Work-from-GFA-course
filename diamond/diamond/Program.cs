using System;

namespace diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // diamond like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //  *****
            //   ***
            //    *
            //
            // The diamond should have as many lines as the number was

            Console.WriteLine("Enter the number of lines: ");
            bool isNum = Int32.TryParse(Console.ReadLine(), out int numberOfLines);

            if (numberOfLines % 2 == 0)
                numberOfLines++;
            
            int middleLine = numberOfLines / 2 + 1;
            int currentLine = 1;

                 //constant values
            int lengthOfTheLastLine = (numberOfLines -1) * 2 +1;  
            int middleOfTheLine = (lengthOfTheLastLine / 2) + 1;
            
            // changing values
            int indentation = middleOfTheLine -1 ;  // length of indentation = number of spaces
            int charsOnCurrentLine = lengthOfTheLastLine - indentation * 2;


            for (; currentLine <= numberOfLines; currentLine++)   // lines
            {
                if (currentLine < middleLine)
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
                else
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

                    indentation += 1;
                    charsOnCurrentLine -= 2;
                }
            }
    
            
            
        }
    }
}
