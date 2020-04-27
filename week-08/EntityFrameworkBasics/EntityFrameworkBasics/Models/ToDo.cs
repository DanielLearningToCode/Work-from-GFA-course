using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkBasics.Models
{
    public class ToDo
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public bool IsUrgent { get; set; }
        public bool IsDone { get; set; }
    }
}
/////Add a Todo class with the following properties:
///(Id: long, Title: string, IsUrgent: boolean(default false), IsDone: boolean(default false))