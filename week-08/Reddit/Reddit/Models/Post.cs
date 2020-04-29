using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Reddit.Models
{
    public class Post
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [MaxLength(200)]
        public string Title { get; set; }
        [MaxLength(200)]
        public string URL { get; set; }
        public int Votes { get; set; }
        [DataType(DataType.DateTime)]
        [ReadOnly(true)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedDate { get; set; }
        public Post()
        {
           // time = DateTime.Now;
        }
    }
}
