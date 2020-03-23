using System;
using System.Collections.Generic;
using System.Text;

namespace green_fox_inheritance
{
    class Mentor: Person
    {
        public enum LevelType { junior, intermediate, senior }
        private LevelType level;

        public Mentor(string name, int age, GenderTypes gender, LevelType level)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.level = level;
        }
        public Mentor()
        {
            name = "Jane Doe";
            age = 30;
            gender = GenderTypes.female;
            level = LevelType.intermediate;

        }
        override public void GetGoal()
        {
            Console.WriteLine("Educate brilliant junior software developers.");
        }
        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {name}, a {age} year old {gender} {level} mentor.");
        }
    }
}

/*Create a Mentor class that has the same fields and methods as the Person class, and has the following additional

    fields:
        level: the level of the mentor(junior / intermediate / senior)
    methods:
        GetGoal() : prints out "Educate brilliant junior software developers."
        Introduce() : "Hi, I'm name, a age year old gender level mentor."

The Mentor class has the following constructors:

    Mentor(name, age, gender, level)
    Mentor() : sets name to Jane Doe, age to 30, gender to female, level to intermediate*/
