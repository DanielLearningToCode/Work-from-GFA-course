using System;
using System.Collections.Generic;
using System.Text;

namespace green_fox_inheritance
{
    class Sponsor : Person
    {
        private string company;
        private int hiredStudents;

        public Sponsor(string name, int age, GenderTypes gender, string company) : base(name, age, gender)
        {
            this.company = company;
            hiredStudents = 0;
        }
        public Sponsor()
        {
            name = "Jane Doe";
            age = 30;
            gender = GenderTypes.female;
            company = "Google";
            hiredStudents = 0;
        }
        override public void Introduce()
        {
            Console.WriteLine($"Hi, I'm {name}, a {age} year old {gender} who represents {company} and hired {hiredStudents} students so far.");
        }
        public void Hire()
        {
            hiredStudents++;
        }
        public override void GetGoal()
        {
            Console.WriteLine("Hire brilliant junior software developers.");
        }
    }
}
/*Create a Sponsor class that has the same fields and methods as the Person class, and has the following additional

    fields:
        company: name of the company
        hiredStudents: number of students hired
    method:
        Introduce() : "Hi, I'm name, a age year old gender who represents company and hired hiredStudents students so far."
        Hire() : increase hiredStudents by 1
        GetGoal() : prints out "Hire brilliant junior software developers."

The Sponsor class has the following constructors:

    Sponsor(name, age, gender, company) : beside the given parameters, it sets hiredStudents to 0
    Sponsor() : sets name to Jane Doe, age to 30, gender to female, company to Google and hiredStudents to 0
*/
