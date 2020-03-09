using System;

namespace Colors
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a two dimensional array
            //   which can contain the different shades of specified colors
            // - In `colors[0]` store the shades of green:
            //   `"lime", "forest green", "olive", "pale green", "spring green"`
            // - In `colors[1]` store the shades of red:
            //   `"orange red", "red", "tomato"`
            // - In `colors[2]` store the shades of pink:
            //   `"orchid", "violet", "pink", "hot pink"`

            string[][] colors = new string[3][]
            {
                new string[]{"lime", "forest green", "olive", "pale green", "spring green"},
                new string[]{"orange red", "red", "tomato"},
                new string[]{"orchid", "violet", "pink", "hot pink"},

            };
            
            for (int row = 0; row < colors.Length; row++)
            {
                for (int column = 0; column < colors[row].Length; column++)
                {
                    Console.Write(colors[row][column] + ", ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
