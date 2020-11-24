using System;
using System.Collections.Generic;
using System.Linq;
using ChatApp.DTO;
using ChatApp.Models;
using ChatApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ChatApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebService service;

        public HomeController(IWebService service)
        {
            this.service = service;
        }

        public IActionResult Index(RequestMessages request)
        {
            return View(service.GetMessages(request));
        }

        [HttpPost("send")]
        public IActionResult Send([FromForm] MessageToSend message)
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
        public IActionResult Login([FromForm] LoginRequest loginRequest)
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
        public IActionResult CreateChannel([FromForm] NewChannelRequest request)
        {
            service.CreateChannel(request);
            return RedirectToAction(nameof(GetChannels));
        }
    }
}