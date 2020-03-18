using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class AnimalClass
    {
        public int Hunger { get; set; }
        public int Thirst { get; set; }

        public AnimalClass()
        {
            Hunger = 50;
            Thirst = 50;
        }
        public void Eat()
        {
            Hunger--;
        }
        public void Drink()
        {
            Thirst--;
        }
        public void Play()
        {
            if (Hunger < 100 && Thirst < 100)
            {
                Hunger++;
                Thirst++;
            }
            else
            {
                Hunger++;
                Thirst++;
                Console.WriteLine("You are about to be eaten"); 
            }
        }
    }
}

   /* Every animal has a hunger value, which is a whole number
    Every animal has a thirst value, which is a whole number
    when creating a new animal object these values are created with the default 50 value
    Every animal can Eat() which decreases their hunger by one
    Every animal can Drink() which decreases their thirst by one
    Every animal can Play() which increases both by one
*/