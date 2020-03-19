using System;
using System.Collections.Generic;
using System.Text;

namespace teachers_and_students
{
    class Teacher
    {
        public string Name { get; set; }
        public void Teach(Student student)
        {
            student.Learn();
        }
        public void Answer()
        {
            Console.WriteLine($"{Name} is answering a question");
        }
    }
}

/*Teach(student) -> calls the students learn method
        Answer() -> prints the teacher is answering a question*/