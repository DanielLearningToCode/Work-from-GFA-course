using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;

namespace ChatApp.Controllers
{
    public class HomeController : Controller
    {

        private readonly WebService service;

        public HomeController(WebService service)
        {
            this.service = service;
        }

        public IActionResult Index(int count = 10)
        {
            MessagesViewModel result = service.GetMessages(count);
            return View(result);
        }

        [HttpPost("send")]
        public IActionResult Send(MessageToSend message)
        {
            service.SendMessage(message);
            return RedirectToAction("Index");
        }

        [HttpGet("Register")]
        public IActionResult Register()
        {

            return View();
        }

        [HttpPost("Register")]
        public IActionResult Register([FromForm] RegisterRequest register)
        {

            return RedirectToAction(nameof(Index));
        }

        [HttpGet("Login")]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost("Login")]
        public IActionResult Login(LoginRequest loginRequest)
        {
            service.Login(loginRequest);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet("LogOut")]
        public IActionResult LogOut()
        {
            service.LogOut();
            return RedirectToAction(nameof(Index));
        }

    }
}