using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFrameworkBasics.Models;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkBasics.Controllers
{
    [Route("todo")]
    public class TodoController : Controller
    {
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("")]
        [Route("list")]
        public IActionResult List()
        {
            List<ToDo> todos = new List<ToDo>() {
                new ToDo { Id = 1, Title = "Sleep", IsDone = false, IsUrgent = true },
                new ToDo{Id = 2, Title = "Work", IsDone = false, IsUrgent = false},
                new ToDo{Id = 3, Title = "Buy milk", IsDone = true, IsUrgent = false } };
            return View(todos);
        }
    }
}