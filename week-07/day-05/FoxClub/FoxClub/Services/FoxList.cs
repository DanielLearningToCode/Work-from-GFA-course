using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Models
{
    public class FoxList
    {
        private List<Fox> foxes;
        private static Fox currentFox;
        public FoxList()
        {
            foxes = new List<Fox>();
        }
        public void AddFox(string name)
        {
            Fox fox = new Fox(name);
            foxes.Add(fox);
        }
        public Fox FindFox(string name)
        {
            return foxes.First(f => f.Name == name);
        }
        public void ChangeNutrition(string name, string food, string drink)
        {
            currentFox = FindFox(name);
            currentFox.Food = food;
            currentFox.Drink = drink;
        }
    }
}
