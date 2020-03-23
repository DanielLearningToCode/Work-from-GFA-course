using System;

namespace garden
{
    class Program
    {
        static void Main(string[] args)
        {
            Garden garden = new Garden();
            garden.Info();
            Console.WriteLine();
            garden.WaterTheGarden(40);
            garden.Info();
            Console.WriteLine();
            garden.WaterTheGarden(70);
            garden.Info();
        }

    }
}
