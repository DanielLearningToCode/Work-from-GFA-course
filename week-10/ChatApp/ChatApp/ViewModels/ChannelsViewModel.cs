using ChatApp.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.ViewModels
{
    public class ChannelsViewModel
    {
        public ICollection<Channel> Channels { get; set; }

        public ChannelsViewModel()
        {
            Channels = new List<Channel>();
        }
    }
}
