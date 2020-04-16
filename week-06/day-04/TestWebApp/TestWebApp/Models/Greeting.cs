using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWebApp.Models
{
    public class Greeting
    {
        public long Id { get; set; }
        public string Content { get; set; }

        public static long counter = 0;

        public Greeting(string content )
        {
            Content = content;
            counter++;
            Id = counter;
        }
        public Greeting()
        {
        }
    }
}
