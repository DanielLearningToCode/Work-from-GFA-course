using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
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
        [MaxLength(300)]
        [Required]
        public string Title { get; set; }
        [Required]
        [MaxLength(500)]
        public string URL { get; set; }
        public int Votes { get; set; }
        [DataType(DataType.DateTime)]
        [ReadOnly(true)]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedDate { get; set; }
        public User User { get; set; }
        [ForeignKey("UserId")]
        public int UserId { get; set; }

    }
}
