using System;
using System.Collections.Generic;
using System.Text;

namespace garden
{
    class Flower : Plant
    {
        public Flower()
        {
            name = "flower";
            color = "green";
        }
        public Flower(string color)
        {
            name = "flower";
            this.color = color;
        }
        override public bool NeedsWater()
        {
            return amountOfWater < 5 ? true : false; 
        }
        override public void Water(double amount)
        {
            amountOfWater += amount * 0.75;
        }
    }
}
