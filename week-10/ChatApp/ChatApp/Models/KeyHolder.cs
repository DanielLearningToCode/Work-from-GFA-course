using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
