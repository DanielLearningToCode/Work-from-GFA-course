using System;

namespace Prezentace_kresleni
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            // smiley face
            for (int rows = 0; rows < 12; rows++)
            {
                for (int columns = 0; columns < 14; columns++)
                {
                    if (rows == 1 && (columns == 4 || columns == 5 || columns == 6 || columns == 7 || 
                        columns == 8 || columns == 9) || rows == 2 && (columns == 2 || columns == 11)
                        || rows == 3 && (columns == 1 || columns == 12) || rows == 4 && (columns == 3 || 
                        columns == 10) || rows == 5 && (columns == 0 || columns == 13) || rows == 6 && 
                        (columns == 0 || columns == 13) || rows == 7 && (columns == 0 || columns == 13) 
                        || rows == 8 && (columns == 3 || columns == 10) || rows == 9 && (columns == 1 ||
                        columns == 4 || columns == 5 || columns == 6 || columns == 7 || columns == 8 || 
                        columns ==  9 || columns == 12) || rows == 10 && (columns == 2 || columns == 11) 
                        || rows == 11 && (columns == 4 || columns == 5 || columns == 6 || columns == 7
                        || columns == 8 || columns ==9))
                    {
                    Console.Write("@");
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
