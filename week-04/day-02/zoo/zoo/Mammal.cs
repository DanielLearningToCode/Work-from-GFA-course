using System;
using System.Collections.Generic;
using System.Text;

namespace zoo
{
    abstract class Mammal : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine(".....");
        }
        public override string WantChild()
        {
            return "wants child from its womb.";
        }
    }
}
