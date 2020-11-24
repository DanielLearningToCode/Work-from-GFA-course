using ChatApp;
using ChatApp.DTO;
using ChatApp.Models;

namespace ChatApp.DTO
{
    public class MessageToSend
    {
        public int? ChannelId { get; set; }
        public string ChannelSecret { get; set; }
        public string Content { get; set; }
    }
}
