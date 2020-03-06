using System;

namespace draw_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // triangle like this:
            //
            // *
            // **
            // ***
            // ****
            //
            // The triangle should have as many lines as the number was

            Console.WriteLine("Enter the number of lines");
            bool isNumber = Int32.TryParse(Console.ReadLine(), out int num);

            int asterisksOnCurrentLine = 1;
            for (int line = 1; line < num; line++)
            {
                asterisksOnCurrentLine = line;


                for (int i = 1; i <= asterisksOnCurrentLine; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }   
    }
}
