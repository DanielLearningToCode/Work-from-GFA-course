using System;

namespace FaktorialWithRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Faktorial(6));
        }

        public static int Faktorial (int num)
        {

            if(num == 1)
            {
                return 1;
            }
            else
            {
                return num * Faktorial(num - 1);
            }

            
                
        }
    }

}
