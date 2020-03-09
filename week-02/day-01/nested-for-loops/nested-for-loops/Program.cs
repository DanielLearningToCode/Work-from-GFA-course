using System;

namespace nested_for_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines;
            Console.WriteLine("Enter the number of lines:");
            bool isNumber = int.TryParse(Console.ReadLine(), out numberOfLines);

            
            int numberOfColumns = numberOfLines;
        

            for (int line = 0; line < numberOfLines; line++)
            {
                for (int column = 0; column < numberOfColumns; column++)
                {
                    if(line == 0 || line == numberOfLines -1 || column == 0 || 
                                column == numberOfColumns -1 || line == column
                                 || line + column == numberOfLines -1)
                    Console.Write("#");
                    else
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
