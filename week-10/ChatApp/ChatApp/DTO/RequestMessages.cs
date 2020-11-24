using ChatApp;
using ChatApp.DTO;
using ChatApp.Models;

namespace ChatApp.DTO
{
    public class RequestMessages
    {
        public int? ChannelId { get; set; }
        public string ChannelSecret { get; set; }
        public int Count { get; set; } = 10;
    }
}