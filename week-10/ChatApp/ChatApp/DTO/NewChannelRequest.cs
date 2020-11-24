using ChatApp;
using ChatApp.DTO;
using ChatApp.Models;

namespace ChatApp.DTO
{
    public class NewChannelRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
