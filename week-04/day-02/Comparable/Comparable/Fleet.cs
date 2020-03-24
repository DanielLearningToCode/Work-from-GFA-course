using System;
using System.Collections.Generic;

namespace Comparable
{
    public class Fleet
    {
        private List<Thing> things;

        public Fleet()
        {
            things = new List<Thing>();
        }

        public void Add(Thing thing)
        {
            things.Add(thing);
        }

        public void SetToCompleted(int indexOfTheitem)
        {
            things[indexOfTheitem-1].Complete();
        }
        public void Print()
        {
            for (int i = 0; i < things.Count; i++)
            {
                Console.WriteLine($"{i+1} {things[i].GetNameAndStatus()}");
            }
        }
    }
}