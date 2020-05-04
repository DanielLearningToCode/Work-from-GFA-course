using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using REST.Models;

namespace REST.Controllers
{
    public class HomeController : Controller
    {
        private readonly Services services;
        public HomeController(Services services)
        {
            this.services = services;
        }

        [Route("/")]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet("doubling/{input?}")]   // sends 200 even when no input is provided
        public dynamic Doubling(int? input)
        {
            if (!input.HasValue)
            {
                return new { error = "Please provide an input!" };
            }
            Doubling result = new Doubling(input);
            return result;
        }

        [HttpGet("greeter")]
        public ActionResult<string> Greeter(Person person)     // Action result returns status
        {
            //return services.Greet(person);
            if (person.Name == null && person.Title == null)
            {
                // return Json(new { error = "Please provide a name and a title!", status = 400 });
                return StatusCode(400, new { error = "Please provide a name and a title!" });
            }
            else if (person.Title == null)
            {
                return StatusCode(400, new { error = "Please provide a title!" });
            }
            else if (person.Name == null)
            {
                return StatusCode(400, new { error = "Please provide a name!" });
            }
            else
            {
                return StatusCode(200, new { welcome_message = $"Oh, hi there {person.Name}, my dear {person.Title}!" });
            }
        }
        [HttpGet("appenda/{appendable?}")]
        public dynamic AppendA(string appendable)
        {
            if (string.IsNullOrEmpty(appendable))
            {
                return StatusCode(404);
            }
            return new { appended = appendable + "a" };
        }

        [HttpPost("dountil/{act}")]
        public ActionResult DoUntil(string act, [FromBody] Number input )
        {
           /* var a = input.ToString();
            int number = JObject.Parse(a)["until"];*/    // using JOBject and parsing it to get te value

            if (input == null)
            {
                return StatusCode(400, new { error = "Please provide a number!" });
            }
            if (act == "sum")
            {
                return StatusCode(200, new { result = Services.Sum(input.Until) });
            }
            else
            {
                return StatusCode(200, new { result = Services.Factor(input.Until) });
            }
        }

        [Route("arrays")]
        [HttpPost]
        public ActionResult Arrays([FromBody] ArrayHandler arrayHandler)
        {
            if (arrayHandler == null || arrayHandler?.What == null || arrayHandler?.Numbers == null)
            {
                return StatusCode(400, new { error = "Please provide what to do with the numbers!" });
            }
            return StatusCode(200, new { result = services.Calculate(arrayHandler) });
        }
    }
}

