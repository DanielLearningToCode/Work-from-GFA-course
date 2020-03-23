using System;
using System.Collections.Generic;
using System.Text;

namespace green_fox_inheritance
{
    class Person
    {
        public enum GenderTypes { male, female}
        protected string name;
        protected int age;
        protected GenderTypes gender;

        /*public string Name 
        {
            get { return name; }
            //private set{}; 
        }
        public int Age 
        { 
            get { return age; }
            //private set {} 
        }
        public genderTypes Gender { get; private set; }
        */
        public Person(string name, int age, GenderTypes gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
        public Person()
        {
            this.name = "Jane Doe"; 
            this.age = 30;
            this.gender = GenderTypes.female;
        }

        virtual public void Introduce()
        {
            Console.WriteLine($"Hi, I'm {name}, a {age} year old {gender}."); 
        }
        virtual public void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }

    }
}
/*Create a Person class with the following fields:
    name: the name of the person
    age: the age of the person(whole number)
    gender: the gender of the person(male / female)
And the following methods:
    Introduce() : prints out "Hi, I'm name, a age year old gender."
    GetGoal() : prints out "My goal is: Live for the moment!"
And the following constructors:
    Person(name, age, gender)
    Person() : sets name to Jane Doe, age to 30, gender to female
*/