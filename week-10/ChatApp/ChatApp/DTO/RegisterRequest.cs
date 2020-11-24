using ChatApp;
using ChatApp.DTO;
using ChatApp.Models;

namespace ChatApp.DTO
{
    public class RegisterRequest
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
