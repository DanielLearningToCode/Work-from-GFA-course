using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using REST.Models;
using REST.Services;
using System.Text.Json;
using System.Text.Json.Serialization;
using HybridModelBinding;

namespace REST.Controllers
{
    public class HomeController : Controller
    {
        private readonly RESTServices restServices;
        private readonly LogServices logServices;
        public HomeController(RESTServices services, LogServices logServices)
        {
            this.restServices = services;
            this.logServices = logServices;
        }

        [Route("/")]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet("doubling/{input?}")]   // sends 200 even when no input is provided
        public dynamic Doubling(int? input)
        {
            Log log = new Log(HttpContext.Request.RouteValues["action"].ToString(), input.ToString());
            logServices.SaveToDatabase(log);
            if (!input.HasValue)
            {
                return StatusCode(400, Json(new { error = "Please provide an input!" }));
            }
            return Json(new { received = input, result = input * 2 });
            //Doubling result = new Doubling(input);
            //return result;
        }

        [HttpGet("greeter")]
        public ActionResult<string> Greeter(Person person)     // Action result returns status
        {
            Log log = new Log(HttpContext.Request.RouteValues["action"].ToString(), JsonSerializer.Serialize(person));
            logServices.SaveToDatabase(log);
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
        [HttpGet("appenda/{appendable}")]
        public ActionResult AppendA(string appendable)
        {
            logServices.SaveToDatabase(new Log(HttpContext.Request.RouteValues["action"].ToString(), appendable.ToString()));
            if (string.IsNullOrEmpty(appendable))
            {
                return StatusCode(404);
            }
            return StatusCode(200, new { appended = appendable + "a" });
        }

        [HttpPost("dountil/{act}")]
        public ActionResult DoUntil(Number input)   // using hybrid model binding extension to catch everything and put it into model
        {
            /* var a = input.ToString();
             int number = JObject.Parse(a)["until"];*/    // using JOBject and parsing it to get the value i/o class
            logServices.SaveToDatabase(new Log(HttpContext.Request.RouteValues["action"].ToString(), JsonSerializer.Serialize(input)));
            if (input.Until == null)
            {
                return StatusCode(400, new { error = "Please provide a number!" });
            }
            else if (input?.Act == "sum")
            {
                return StatusCode(200, new { result = RESTServices.Sum((int)input.Until) });
            }
            else if(input?.Act == "factor")
            {
                return StatusCode(200, new { result = RESTServices.Factor((int)input.Until) });
            }
            else
            {
                return StatusCode(400, new { error = "Please provide valid operation in URL. /Sum or /Factor. " });
            }
        }

        [Route("arrays")]
        [HttpPost]
        public ActionResult Arrays([FromBody] ArrayHandler arrayHandler)
        {
            logServices.SaveToDatabase(new Log(HttpContext.Request.RouteValues["action"].ToString(), JsonSerializer.Serialize(arrayHandler)));
            if (arrayHandler == null || arrayHandler?.What == null || arrayHandler?.Numbers == null)
            {
                return StatusCode(400, new { error = "Please provide what to do with the numbers!" });
            }
            return StatusCode(200, new { result = restServices.Calculate(arrayHandler) });
            //return StatusCode(200, new { result = restServices.Calculate(arrayHandler) });
        }
        [HttpGet("log")]
        public Logs GetLogs()
        {
            string endpoint = HttpContext.Request.RouteValues["action"].ToString();
            logServices.SaveToDatabase(new Log(endpoint));
            return logServices.GetLogEntries();
        } 
        [HttpPost("sith")]
        public JsonResult Sith(TextForSith input)
        {
            logServices.SaveToDatabase(new Log(HttpContext.Request.RouteValues["action"].ToString(), JsonSerializer.Serialize(input)));
            if (input?.Text == null)
            {
                return Json(new { error = "Feed me some text you have to, padawan young you are. Hmmm." });
            }
            return Json(new { sith_text = restServices.Sith(input) });
        }
    }
}

