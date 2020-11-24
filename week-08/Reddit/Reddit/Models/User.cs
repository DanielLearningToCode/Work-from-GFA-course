using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Reddit.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(200)]
        public string Name { get; set; }
        public ICollection<Post> Posts { get; set; }

        public User()
        {
            Posts = new List<Post>();
        }
    }
}
