﻿using System;

namespace draw_chess_table
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crate a program that draws a chess table like this
            //
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            // % % % %
            //  % % % %
            //
            for (int i = 0; i < 8; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("% % % %");
            }

        }
    }
}
