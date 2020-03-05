using System;


namespace VariableMutation
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            // make it bigger by 10

            Console.WriteLine(a + 10);

            int b = 100;
            // make it smaller by 7

            Console.WriteLine(b - 7);

            int c = 44;
            // please double c's value

            Console.WriteLine(c * 2);

            int d = 125;
            // please divide by 5 d's value

            Console.WriteLine(d / 5);

            int e = 8;
            // please cube of e's value

            Console.WriteLine(e * e * e);

            int f1 = 123;
            int f2 = 345;
            bool biggerNum = f1 > f2;
            Console.WriteLine("f1 > f2: " + biggerNum);
            // tell if f1 is bigger than f2 (print as a boolean)

            int g1 = 350;
            int g2 = 200;
            Console.WriteLine("2 * g2 > g1: " + ((g2 * 2) > g1));
            // tell if the double of g2 is bigger than g1 (print as a boolean)

            long h = 1357988018575474;
            bool delitelnost = false;
            if (h % 11 == 0)
                delitelnost = true;
            Console.WriteLine(delitelnost);
            // tell if 11 is a divisor of h (print as a boolean)

            int i1 = 10;
            int i2 = 3;
            Console.WriteLine("Is h1 higher than i2 squared and smaller than i2 cubed: " + ((i1 > (i2 * i2)) && (i1 < (i2 * i2 * i2))));
            // tell if i1 is higher than i2 squared and smaller than i2 cubed (print as a boolean)

            int j = 1521;

            bool divisibility = ((j % 3) == 0  || (j % 5) == 0);
            // tell if j is divisible by 3 or 5 (print as a boolean)

            Console.WriteLine(j + " is divisible by 3 or 5: " + divisibility);
        }
    }
}
