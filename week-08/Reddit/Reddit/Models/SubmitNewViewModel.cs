using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reddit.Models
{
    public class SubmitViewModel
    {
        public ICollection<string> Users { get; set; }
        public SubmitViewModel()
        {
            Users = new List<string>();
        }
    }
}
