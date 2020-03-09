using System;

namespace DiagonalMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create (dynamically) a two dimensional array
            //   with the following matrix. Use a loop!
            //
            //   1 0 0 0
            //   0 1 0 0
            //   0 0 1 0
            //   0 0 0 1
            //
            // - Print this two dimensional array to the output

            for (int row = 0; row < 4; row++)
            {
                for (int column = 0; column < 4; column++)
                {
                    if (row != column)
                    {
                        Console.Write("0");
                    }
                    else
                    {
                        Console.Write("1");
                    }

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
