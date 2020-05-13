using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Models
{
    public class IndexViewModel
    {
        public List<Message> Messages { get; set; }
        public Channel Channel { get; set; }
        public int Count { get; set; }
        public bool LogInSuccess { get; set; }

        public List<Channel> Channels { get; set; }
        public IndexViewModel()
        {
            Messages = new List<Message>();
            Channels = new List<Channel>();
        }
    }
}
