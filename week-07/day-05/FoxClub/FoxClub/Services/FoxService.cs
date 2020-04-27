using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Models
{
    public class FoxService
    {
        private List<Fox> foxes;
        private static Fox currentFox;
        public Fox DefaultFox { get; set; }
        public FoxService()
        {
            DefaultFox = new Fox();
            foxes = new List<Fox>() { DefaultFox };
        }
        public void AddFox(string name)
        {
            if (FindFox(name) == null)
            {
                foxes.Add(new Fox(name));
            }
        }
        public Fox FindFox(string name)
        {
            return foxes.FirstOrDefault(f => f.Name == name);
            //return foxes.First(f => f.Name == name);
        }
        public void ChangeNutrition(string name, string food, string drink)
        {
            currentFox = FindFox(name);
            currentFox.Food = food;
            currentFox.Drink = drink;
        }
        public void AddTrick(string name, string trick)
        {
            FindFox(name).Tricks.Add(trick);
        }
        public List<Fox> GetFoxes()
        {
            return foxes;
        }
    }
}
