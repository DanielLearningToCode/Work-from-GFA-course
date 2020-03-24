using System;
using System.Collections.Generic;
using System.Text;

namespace zoo
{
    abstract class Reptile : Animal
    {

        public override void MakeSound()
        {
            Console.WriteLine("Sssss");
        }
        public override string WantChild()
        {
            return "wants child from an egg";
        }
    }
}
