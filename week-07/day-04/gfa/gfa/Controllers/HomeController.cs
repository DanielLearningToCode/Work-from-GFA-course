using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gfa.Services;
using Microsoft.AspNetCore.Mvc;

namespace gfa.Controllers
{
    [Route("gfa")]
    public class HomeController : Controller
    {
        IStudentService service;
        public HomeController(IStudentService service)
        {
            this.service = service;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            return View(service.Count());
        }
        [HttpGet("list")]
        public IActionResult ListAll()
        {
            return View(service.FindAll());
        }
        [HttpGet("add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpGet("save")]
        public IActionResult Save(string name)
        {
            service.Save(name);
            return RedirectToAction("ListAll");     // must be the method name, not the route
        }
        [HttpGet("check")]
        public IActionResult Check(string name)
        {
            string result = name != null ? service.Check(name) : "";
            return View(result as object);
        }
    }
}