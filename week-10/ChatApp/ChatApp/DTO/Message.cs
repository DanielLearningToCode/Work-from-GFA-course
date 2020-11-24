using ChatApp.Models;
using System;

namespace ChatApp.DTO
{
    public class Message
    {
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public Author Author { get; set; }
        public Channel Channel { get; set; }

    }
}