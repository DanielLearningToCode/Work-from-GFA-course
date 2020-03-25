using System;
using System.Collections.Generic;
using System.Text;

namespace flyable
{
    class Helicopter : Vehicle, IFlyable
    {
        public Helicopter(string make, double maxAltitude, double maxSpeed)
        {
            this.make = make;
            this.maxAltitude = maxAltitude;
            this.maxSpeed = maxSpeed;
        }
        public void Fly(double speed)
        {
            if (currentAltitude == 0)
            {
                TakeOff();
            }
            currentSpeed += speed;
        }
        public void TakeOff()
        {
            currentAltitude = 10;
        }
        public void Land()
        {
            currentSpeed = 0;
            currentAltitude = 0;
        }
    }
}
