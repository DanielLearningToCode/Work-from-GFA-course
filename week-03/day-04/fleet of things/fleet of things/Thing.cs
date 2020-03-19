using System;

namespace FleetOfThings
{
    public class Thing
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
    }
}