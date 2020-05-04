using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using REST.Models;

namespace REST.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet("doubling")]
        public Doubling Doubling(int? input)
        {
            Doubling result;
            if (input == null)
            {
                result = new Doubling() { Error = "Please provide an input!" };
                return result;
            }
            result = new Doubling(input);
            return result;
        }
    }
}