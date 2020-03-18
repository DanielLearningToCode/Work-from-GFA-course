using System;

namespace sharpie
{
    class Program
    {
        static void Main(string[] args)
        {
            Sharpie bluePen = new Sharpie("Blue", 1);
            while (bluePen.InkAmount > 0)
            {
                bluePen.Use();
                Console.WriteLine(bluePen.InkAmount);
            }
        }
    }
}
