using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace EntityFrameworkBasics.Models
{
    public class ToDo
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [MaxLength (100)]
        public string Title { get; set; }
        public string Description { get; set; }
        [DefaultValue(false)]
        public bool IsUrgent { get; set; }
        public bool IsDone { get; set; }
        public int AssigneeId { get; set; }
        public Assignee Assignee { get; set; }
    }
}
/////Add a Todo class with the following properties:
///(Id: long, Title: string, IsUrgent: boolean(default false), IsDone: boolean(default false))