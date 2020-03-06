using System;

namespace square
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // square like this:
            //
            //
            // %%%%%%
            // %    %
            // %    %
            // %    %
            // %    %
            // %%%%%%
            //
            // The square should have as many lines as the number was

            Console.WriteLine("Enter a number: ");
            bool isNum = Int32.TryParse(Console.ReadLine(), out int numberOfLines);
           
            for (int line = 1; line <= numberOfLines; line++)
            {
                for(int column = 1; column <= numberOfLines; column++)
                {
                    if (line == 1 || line == numberOfLines)  // first and last line
                    {
                        Console.Write("%");
                    }
                    else if(column == 1 || column == numberOfLines)
                    {
                        Console.Write("%");
                    }
                    else
                    {
                        Console.Write(" "); 
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
