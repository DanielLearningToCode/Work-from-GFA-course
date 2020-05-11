using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Models
{
    public class Response
    {
        public List<Message> Messages { get; set; }

        public Response()
        {
            Messages = new List<Message>();
        }
    }
}
