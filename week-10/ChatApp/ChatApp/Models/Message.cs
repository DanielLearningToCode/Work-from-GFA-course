using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Models
{
    public class Message
    {
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public Author Author { get; set; }
        public Channel Channel { get; set; }

    }
}