using System;
using System.Collections.Generic;
using System.Text;
using flyable;

namespace zoo
{
    class Bird : Animal, IFlyable
    {
        protected double currentSpeed;
        protected double currentAltitude;
        public Bird(string name) : base(name) { }

        public double GetSpeed()
        {
            return currentSpeed;
        }
        public double GetAltitude()
        {
            return currentAltitude;
        }
        public void Fly(double speed)
        {
            if (currentAltitude == 0)
            {
            TakeOff();
            }
            this.currentSpeed += speed; 
        }

        public void Land()
        {
            currentSpeed = 0;
        }

        public override void MakeSound()
        {
            Console.WriteLine("tweet");
        }

        public void TakeOff()
        {
            currentAltitude += 10;
        }

        public override string WantChild()
        {
            return "wants child from an egg";
        }
    }
}
