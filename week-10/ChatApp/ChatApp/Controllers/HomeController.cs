using System;
using System.Collections.Generic;
using System.Linq;
using ChatApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChatApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly WebService service;

        public HomeController(WebService service)
        {
            this.service = service;
        }

        public IActionResult Index(RequestMessages request)
        {
            return View(service.GetMessages(request));
        }

        [HttpPost("send")]
        public IActionResult Send(MessageToSend message)
        {
            service.SendMessage(message);
            return RedirectToAction("Index", new RequestMessages() { ChannelId = message.ChannelId, ChannelSecret = message.ChannelSecret });
        }

        [HttpGet("Register")]
        public IActionResult Register()
        {
            return View("Register");
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

        [HttpGet("GetChannels")]
        public IActionResult GetChannels()
        {
            return View("Channels", service.GetChannels());
        }

        [HttpPost("CreateChannel")]
        public IActionResult CreateChannel (NewChannelRequest request)
        {
            service.CreateChannel(request);
            return RedirectToAction(nameof(GetChannels));
        }
    }
}