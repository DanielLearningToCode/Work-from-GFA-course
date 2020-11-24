using System.ComponentModel.DataAnnotations;

namespace ChatApp.Models
{
    public class KeyHolder
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        public string ApiKey { get; set; }
    }
}
