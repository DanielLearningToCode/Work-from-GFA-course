using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST.Models
{
    public class Logs
    {
        public int EntryCount { get; set; }
        public ICollection<Log> Entries { get; set; }
        public Logs()
        {
            Entries = new List<Log>();
        }
    }
}
