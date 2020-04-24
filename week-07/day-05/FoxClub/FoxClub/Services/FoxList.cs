using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Models
{
    public class FoxList
    {
        private List<Fox> foxes;
        public FoxList()
        {
            foxes = new List<Fox>();
        }
        public void AddFox(Fox fox)
        {
            foxes.Add(fox);
        }
        public Fox FindFox(string name)
        {
            return foxes.First(f => f.Name == name);
        }
    }
}
