using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Title { get; set; }

        public Person()
        {

        }
        public Person(string name, string title)
        {
            Name = name;
            Title = title;
        }
    }
}
