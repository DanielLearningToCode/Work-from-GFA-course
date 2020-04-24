using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxClub.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FoxClub.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        private FoxList foxService;
        public HomeController(FoxList foxService)
        {
            this.foxService = foxService;
        }

        [HttpGet("")]
        public IActionResult Index(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
            Fox defaultFox = new Fox();
            defaultFox.Tricks.Add("Write Html");
            defaultFox.Tricks.Add("Code in Java");
            return View(defaultFox); 
            }
            return View(foxService.FindFox(name));
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost("login")]
        public IActionResult Login(Fox fox)
        {
            foxService.AddFox(fox);
            return RedirectToAction("Index", fox);
        }
    }
}