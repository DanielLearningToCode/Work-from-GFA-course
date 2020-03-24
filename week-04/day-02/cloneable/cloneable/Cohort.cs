using System;
using System.Collections.Generic;
using System.Text;

namespace cloneable
{
    class Cohort
    {
        private string name;
        private List<Student> studentList;
        private List<Mentor> mentorList;

        public Cohort(string name) 
        {
            this.name = name;
            studentList = new List<Student>();
            mentorList = new List<Mentor>();
        }
            

        public void AddStudent(Student student)
        {
            studentList.Add(student);
        }
        public void AddMentor(Mentor mentor)
        {
            mentorList.Add(mentor);
        }
        public void Info()
        {
            Console.WriteLine($"The {name} cohort has {studentList.Count} students and {mentorList.Count} mentors.");
        }
        
    }
}

/*Create a Cohort class that has the following

    fields:
        name: the name of the cohort
        students: a list of Students
        mentors: a list of Mentors
    methods:
        addStudent(Student) : adds the given Student to students list
         addMentor(Mentor): adds the given Mentor to mentors list
         info(): prints out "The name cohort has students.size() students and mentors.size() mentors."

The Cohort class has the following constructors:

    Cohort(name) : beside the given parameter, it sets students and mentors as empty lists
*/