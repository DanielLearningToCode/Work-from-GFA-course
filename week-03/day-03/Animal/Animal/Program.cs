using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalClass dog = new AnimalClass();
            Console.WriteLine(dog.Hunger);
            while (dog.Hunger <= 100)
            {
                dog.Play();
                Console.WriteLine(dog.Hunger);
            }
            Console.WriteLine();
        }
    }
}
