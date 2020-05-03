using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gfa.Services
{
    public class StudentService : IStudentService
    {
        private readonly List<string> names;

        public StudentService()
        {
            names = new List<string> { "Sanyi", "Lilla", "John" };
        }

        public List<string> FindAll()
        {
            return names;
        }

        public void Save(string student)
        {
            if (char.IsLower(student[0]))
            {
                student = Capitalize(student);
            }
            names.Add(student);
        }
        public int Count()
        {
            return names.Count;
        }
        public string Check(string name)
        {
            name = char.IsLower(name[0]) ? Capitalize(name) : name;
            return names.Contains(name) ? "The name is already in the list." : "The name is not in.";
        }
        public static string Capitalize(string input)
        {
            string result = "";
            input = input.Trim();
            if (input.Length > 1)
            {
                result = string.Concat(char.ToUpper(input[0]), input.Substring(1));
            }
            return result;
        }
    }
}
