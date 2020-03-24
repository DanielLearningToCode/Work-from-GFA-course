using System;

namespace cloneable
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Student("john", 20, Person.GenderTypes.male, "BME");
            Student johnTheClone = john.Clone() as Student;
            johnTheClone.Introduce(); 
        }
    }
}
