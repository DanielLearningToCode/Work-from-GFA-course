using System;

namespace teachers_and_students
{
    class Program
    {
        static void Main(string[] args)
        {
            Student john = new Student();
            Teacher fred = new Teacher();

            john.Name = "John";
            fred.Name = "Fred";

            john.Learn();
            john.Question(fred);
            fred.Answer();
            fred.Teach(john);
        }
    }
}

/*Create Student and Teacher classes
Student
        Learn() -> prints the student is learning something new
        Question(teacher) -> calls the teachers answer method
    Teacher
        Teach(student) -> calls the students learn method
        Answer() -> prints the teacher is answering a question
    Instantiate a Student and Teacher object
    Call the student's Question() method and the teacher's Teach() method
*/