using System;

namespace ReverseList
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `aj`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Reverse the order of the elements in `aj`
            // - Print the elements of the reversed `aj`

            int[] aj = { 3, 4, 5, 6, 7 };

            //Array.Reverse(aj);
            //Array.Sort(aj);
            /*for(int i = 0; i < aj.Length; i++)
            {
                Console.WriteLine(aj[i]);
            }*/
            

            for (int i = 0; i < aj.Length / 2; i++)
            {
                int temp = aj[i];
                aj[i] = aj[aj.Length - 1 - i];
                aj[aj.Length - 1 - i] = temp;
            }

            for (int i = 0; i < aj.Length; i++)
            {
                Console.WriteLine(aj[i]);
            }

            Console.ReadLine();
        }
    }
}
