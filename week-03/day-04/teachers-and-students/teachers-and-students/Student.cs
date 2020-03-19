using System;
using System.Collections.Generic;
using System.Text;

namespace teachers_and_students
{
    class Student
    {
        public string Name { get; set; }
        public void Learn()
        {
            Console.WriteLine($"The {Name} is learning something new");
        }
        public void Question(Teacher teacher)
        {
            teacher.Answer();
        }
    }
}
/*Learn() -> prints the student is learning something new
        Question(teacher) -> calls the teachers answer method*/