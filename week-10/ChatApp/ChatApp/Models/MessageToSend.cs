using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Models
{
    public class MessageToSend
    {
        public int? ChannelId { get; set; }
        public string ChannelSecret { get; set; }
        public string Content { get; set; }
    }
}
