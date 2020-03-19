using System;

namespace Hvezda
{
    class Program
    {
        static void Main(string[] args)
        {

           /* (row == numberOfLines / 2 || column == numberOfLines / 2 ||
                        row + column == numberOfLines - 1 || column == row ||
                        column == numberOfLines || column == 0 || row == 0 ||
                        row == numberOfLines)*/


























            int numberOfLines = 15;
            for (int row = 0; row <= numberOfLines; row++)
            {
                for (int column = 0; column <= numberOfLines; column++)
                {
                    if (row == numberOfLines / 2 || column == numberOfLines / 2 ||
                        row + column == numberOfLines || column == row ||
                        column == numberOfLines || column == 0 || row == 0 ||
                        row == numberOfLines)
                    {
                    Console.Write("*");
                        
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
