using System;

namespace Comparable
{
    public class Thing : IComparable
    {
        private string name;
        private bool completed;
        public Thing(string name)
        {
            this.name = name;
        }
        public void Complete()
        {
            completed = true;
        }
        public string GetNameAndStatus()
        {
            if (completed)
            {
                return $"[x] {name}";
            }
            else
            {
                return $"[ ] {name}";
            }
        }
        public int CompareTo(object obj)
        {
            int comparisonResult = 0;
            Thing thing = obj as Thing;
            if (completed == thing.completed)
            {
                if (name.CompareTo(thing.name) < 0)
                {
                    comparisonResult = -1;
                }
                else
                {
                    comparisonResult = 1;
                }
            }
            else if(completed && !thing.completed)
            {
                comparisonResult = -1;
            }
            else
            {
                comparisonResult = 1;
            }
            return comparisonResult;
        }

    }
}