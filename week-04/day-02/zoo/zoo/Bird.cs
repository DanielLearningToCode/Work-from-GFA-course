using System;
using System.Collections.Generic;
using System.Text;

namespace zoo
{
    abstract class Bird : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("tweet");
        }
        public override string WantChild()
        {
            return "wants child from an egg";
        }
    }
}
