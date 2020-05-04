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
        public dynamic Doubling(int? input)
        {
            if (input == null)
            {
                return new { error = "Please provide an input!" };
            }
            Doubling result = new Doubling(input);
            return result;
        }
    }
}