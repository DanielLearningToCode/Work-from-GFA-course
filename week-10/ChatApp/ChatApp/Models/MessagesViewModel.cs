using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Models
{
    public class MessagesViewModel
    {
        public ICollection<Message> Messages { get; set; }
        public int Count { get; set; }

        public MessagesViewModel()
        {
            Messages = new List<Message>();
        }
    }
}
