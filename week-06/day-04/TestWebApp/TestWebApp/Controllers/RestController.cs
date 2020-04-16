using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestWebApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestWebApp.Controllers
{
    [Route("api")]
    public class RestController : Controller
    {
        [HttpGet("greeting")]
        public Greeting Greet(string name)
        {
            var person = new Greeting(name);
            return person;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
////


