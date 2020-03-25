using System;
using printable;
namespace FleetOfThings
{
    public class Thing : IPrintable
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

        public void PrintAllFields()
        {
            string status = completed ? "[x]" : "[ ]";
            Console.WriteLine($"{status} {name}" );
        }
    }
}