using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Models
{
    public class ChannelsViewModel
    {
        public ICollection<Channel> Channels { get; set; }
        //public Channel Channel { get; set; }

        public ChannelsViewModel()
        {
            Channels = new List<Channel>();
        }
    }
}
