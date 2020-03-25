using System;
using System.Collections.Generic;
using System.Text;

namespace flyable
{
    abstract class Vehicle
    {
        public double CurrentAltitude
        {
            get { return currentAltitude; }
        }
        public double CurrentSpeed
        {
            get { return currentSpeed; }
        }
        public string Make
        {
            get { return make; }
        }

        protected double maxAltitude;
        protected double currentAltitude;
        protected double maxSpeed;
        protected double currentSpeed;
        protected string make;
    }
}
/*Create an abstract Vehicle class
        it should have at least 3 fields
*/
