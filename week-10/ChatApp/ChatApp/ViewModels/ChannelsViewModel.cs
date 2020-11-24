using ChatApp.Models;
using System.Collections.Generic;


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
