using System;
using System.Collections.Generic;
using System.Text;

namespace flyable
{
    interface IFlyable
    {
        void Land();
        void Fly(double speed);
        void TakeOff();
    }
}


/*
Create a Flyable interface
    it should have land, fly and takeOff methods(TakeOff in C#)
    
    Extend Helicopter class from Vehicle
        implement your Flyable interface
    Extend Bird from your abstract Animal class (zoo exercise)
        implement your Flyable interface
*/