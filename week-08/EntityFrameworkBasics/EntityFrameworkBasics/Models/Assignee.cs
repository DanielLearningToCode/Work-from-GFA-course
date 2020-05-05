using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkBasics.Models
{
    public class Assignee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Email{ get; set; }
        public  ICollection<ToDo> ToDos { get; set; }

        public Assignee()
        {
            ToDos = new List<ToDo>();
        }
    }
}