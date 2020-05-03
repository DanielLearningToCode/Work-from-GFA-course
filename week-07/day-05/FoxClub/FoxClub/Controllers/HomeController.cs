using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxClub.Models;
using FoxClub.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FoxClub.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        private FoxService foxService;
        public FoxesViewModel FoxesViewModelProp { get; set; }
        //private FoxesViewModel foxesViewModel;
        public HomeController(FoxService foxService, FoxesViewModel foxesViewModel)
        {
            this.foxService = foxService;
            FoxesViewModelProp = foxesViewModel;
        }

        [HttpGet("")]
        public IActionResult Index(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                return View(foxService.DefaultFox);
            }
            return View(foxService.FindFox(Name));
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("login")]
        public IActionResult Login(string name)
        {
            foxService.AddFox(name);
            return RedirectToAction("Information", new { name = name });
        }

        [HttpGet("Nutrition")]
        public IActionResult NutritionStore(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                return RedirectToAction("Login");
            }
            return View(foxService.FindFox(Name));
        }

        [HttpPost("Nutrition")]
        public IActionResult NutritionStore(string Name, string Food, string Drink)
        {
            foxService.ChangeNutrition(Name, Food, Drink);
            return RedirectToAction("Index", new { name = Name });
        }

        [HttpGet("Info")]
        public IActionResult Information(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return View(foxService.DefaultFox);
            }
            return View(foxService.FindFox(name));
        }

        [HttpGet("Tricks")]
        public IActionResult Tricks(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return RedirectToAction("Login");
            }
            return View(foxService.FindFox(name));
        }

        [HttpPost("Tricks")]
        public IActionResult Tricks(string name, string trick)
        {
            if (string.IsNullOrEmpty(name))
            {
                return RedirectToAction("Login");
            }
            foxService.AddTrick(name, trick);
            return View(foxService.FindFox(name));
        }
        [HttpGet("Members")]
        public IActionResult ShowMembers(string ?name)
        {
            return View(FoxesViewModelProp);
        }
    }
}