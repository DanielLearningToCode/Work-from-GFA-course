using EntityFrameworkBasics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkBasics
{
    public class CreateViewModel
    {
        public Assignee Assignee { get; set; }
        public ToDo Todo { get; set; }

        public List<Assignee> Assignees { get; set; }

        public CreateViewModel()
        {
            Assignees = new List<Assignee>();
        }
    }
}
