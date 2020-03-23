using System;
using System.Collections.Generic;
using System.Text;

namespace garden
{
    class Tree : Plant
    {
        public Tree()
        {
            name = "tree";
            color = "green";
        }
        public Tree(string color)
        {
            name = "tree";
            this.color = color;
        }
        override public bool NeedsWater()
        {
            return amountOfWater < 10 ? true : false;
        }
        override public void Water(double amount)
        {
            amountOfWater += amount * 0.4;
        }
    }
}
