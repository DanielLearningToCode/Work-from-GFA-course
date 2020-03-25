using System;
using System.Collections.Generic;
using System.Text;

namespace zoo
{
    abstract class Animal
    {
        public enum gendertypes { male, female}
        protected string name;
        protected int age;
        protected gendertypes gender;
        public Animal(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return this.name;
        }
        public gendertypes GetGender()
        {
            return this.gender;
        }

        public virtual void Greet()
        {
            Console.WriteLine($"Hi, I am {name}");
        }
        public abstract void MakeSound();
        public abstract string WantChild();
    }
}
