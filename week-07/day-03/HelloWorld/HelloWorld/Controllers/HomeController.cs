using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorld.Services;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
     [Route("useful")]
    public class HomeController : Controller
    {
        UtilityService utilityService;
        public HomeController(UtilityService utilityService)
        {
            this.utilityService = utilityService;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpGet("color")]
        public IActionResult Colored()
        {
            string color = utilityService.RandomColor();
            return View("colored", color);
        }
        [HttpGet("email")]
       public IActionResult EmailValidator(string email)
        {
            string[] answer = new string [2];
            if (email != null)
            {
                answer = utilityService.ValidateEmail(email);
            }
            else
            {
                answer[0] = "no email given";
                answer[1] = "red";
            }
            return View(answer as object);
        }
        [HttpGet("caesar")]
        public IActionResult Caesar (string text, int number, string operation)
        {   int num = operation == "encode" ? number : -number;
            string result = (text != null) ? utilityService.Caesar(text, num) : "Enter the text to be encoded";
            string[] resultForView = { text, result };
            return View(resultForView as object);
        }
    }
}