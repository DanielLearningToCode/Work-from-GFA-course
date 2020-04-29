using EntityFrameworkBasics.Models;
using EntityFrameworkBasics.Services;
using EntityFrameworkBasics;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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

        [HttpGet("")]
        [HttpGet("index")]
        public IActionResult Index(bool isActive)
        {
            List<ToDo> result = isActive ? toDoService.ReturnActiveTasks() : toDoService.ListTasks();
            return View(result);
        }

        [HttpPost("index")]
        public IActionResult Index(string searchedText)
        {
            List<ToDo> filteredList = toDoService.Search(searchedText);
            return View("Index", filteredList);
        }

        [HttpGet("add")]
        public IActionResult Create()
        {
            CreateViewModel viewModel = new CreateViewModel { Assignees = toDoService.ListAssignees() };
            return View(viewModel);
        }

        [HttpPost("add")]
        public IActionResult Create(string title, string assignee)
        {
            toDoService.CreateTask(title, assignee);
            return RedirectToAction("Index");
        }

        [HttpGet("{id}/Delete")]
        public IActionResult Delete([FromRoute] long id)
        {
            toDoService.DeleteTask(id);
            return RedirectToAction("Index");
        }

        [HttpGet("{id}/Edit")]
        public IActionResult Edit([FromRoute]long id)
        {
            return View(toDoService.GetTask(id));
        }

        [HttpPost("{id}/Edit")]
        public IActionResult Edit([FromRoute]long id, string title, string description, bool isDone, bool isUrgent)
        {
            ToDo task = toDoService.GetTask(id);
            toDoService.EditTask(task, title, description, isDone, isUrgent);
            return View(task);
        }

        [HttpGet("assignees")]
        public IActionResult ShowAssignees()
        {
            List<Assignee> assignees = toDoService.ListAssignees();
            return View(assignees);
        }

        [HttpPost("AddAssignee")]
        public IActionResult AddAssignee(Assignee assignee)
        {
            toDoService.CreateAssignee(assignee);
            return RedirectToAction("ShowAssignees");
        }

        [HttpGet("{id}/DeleteAssignee")]
        public IActionResult DeleteAssignee([FromRoute] int id)
        {
            toDoService.DeleteAssignee(id);
            return RedirectToAction("ShowAssignees");
        }

        [HttpPost("EditAssignee")]
        public IActionResult EditAssignee(int id, string name, string email)
        {
            toDoService.EditAssignee(id, name, email);
            return RedirectToAction("ShowAssignees");
        }

        /*public IActionResult Search(string searchedText)
        {                                                           // search for just one task
            ToDo task = toDoService.Search(searchedText);
            long result = task != null? task.Id : 0;
            return RedirectToAction("Edit", new { id = result });
        }*/
    }
}
/////
///things to do:
///date and time for tasks
///searching by date and time
///searching should be case-insensitive
///handle cases with assigning tasks to not-existing users