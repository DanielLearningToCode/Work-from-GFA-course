using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Models
{
    public class RequestMessages
    {
        public int? ChannelId { get; set; }
        public string ChannelSecret { get; set; }
        public int Count { get; set; } = 10;
    }
}