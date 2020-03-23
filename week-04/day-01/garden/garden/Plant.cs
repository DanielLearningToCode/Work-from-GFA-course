using System;
using System.Collections.Generic;
using System.Text;

namespace garden
{
    class Plant
    {
        protected string color;
        protected double amountOfWater = 0;
        protected string name;

        public string Name
        {
            get { return name; }
        } 
        public string Color
        {
            get { return color; }
        }
        public Plant()
        {
            color = "green";
            name = "plant";
        }
        virtual public bool NeedsWater()
        {
            return amountOfWater < 5 ? true : false;
        }
        virtual public void Water(double amount)
        {
            amountOfWater += amount;
        }
        
    }
}
