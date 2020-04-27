using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFrameworkBasics.Models;
using EntityFrameworkBasics.Services;
using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkBasics.Controllers
{
    [Route("todo")]
    public class TodoController : Controller
    {
        private ToDoService toDoService;
        public TodoController(ToDoService toDoService)
        {
            this.toDoService = toDoService;
        }
        [Route("")]
        [Route("index")]
        public IActionResult Index(bool isActive)
        {
            List<ToDo> result = isActive ? toDoService.ReturnActiveTasks() : toDoService.ListTasks();
            return View(result);
        }
        [HttpGet("add")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost("add")]
        public IActionResult Create(ToDo task)
        {
            toDoService.CreateTask(task);
            return RedirectToAction("Index");
        }

        [HttpGet("/Delete/{id}")]
        public IActionResult Delete([FromRoute] long id)
        {
            toDoService.DeleteTask(id);
            return RedirectToAction("Index");
        }
        [HttpGet("Edit/{id}")]
        public IActionResult Edit([FromRoute]long id)
        {
            return View(toDoService.GetTask(id));
        }
        [HttpPost("Edit/{id}")]
        public IActionResult Edit([FromRoute]long id, string title, bool isDone, bool isUrgent)
        {
            ToDo task = toDoService.GetTask(id);
            toDoService.EditTask(task, title, isDone, isUrgent);
            return View(task);
        }
    }
}