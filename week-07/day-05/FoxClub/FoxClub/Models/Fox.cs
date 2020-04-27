using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Models
{
    public class Fox
    {
        //public enum Foods { pizza, salad, baguette}
        //public enum Drinks { milk, water, lemonade}
        public string Name { get; set; }
        public List<string> Tricks { get; set; }
        public string Food { get; set; }
        public string Drink { get; set; }
        public Fox(string name, string food = "salad", string drink = "water")
        {
            Name = name;
            Tricks = new List<string>();
            Food = food;
            Drink = drink;
        }
        public Fox()
        {
            Name = "Mr Fox";
            Tricks = new List<string>() { "Write HTML", "Code in Java" };
            Food = "pizza";
            Drink = "lemonade";
        }
    }
}
/////create a Fox.cs model
//it should represent a virtual fox
//it should have at least the followings: name, list of tricks, food and drink
//consider using more classes or enums
//this model should be used in services and controllers