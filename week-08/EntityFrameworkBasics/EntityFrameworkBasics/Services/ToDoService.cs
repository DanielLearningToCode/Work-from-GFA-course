using EntityFrameworkBasics.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkBasics.Services
{
    public class ToDoService
    {
        private readonly ApplicationContext db;
        public ToDoService(ApplicationContext db)
        {
            this.db = db;
        }
        public List<ToDo> ListTasks()
        {
            return db.Todos.Include(a => a.Assignee).ToList();
        }

        public List<ToDo> ReturnActiveTasks()
        {
            return db.Todos.Where(t => !t.IsDone).Include(t => t.Assignee).ToList();
        }
        public void CreateTask(string title, string name)
        {
            Assignee currentOne = db.Assignees.FirstOrDefault(a => a.Name.Equals(name));
            ToDo newTask = new ToDo() { Title = title, Assignee = currentOne };
            db.Todos.Add(newTask);
            db.SaveChanges();
        }
        public void DeleteTask(long id)
        {
            db.Todos.Remove(db.Todos.FirstOrDefault(t => t.Id == id));
            db.SaveChanges();
        }
        public ToDo GetTask(long id)
        {
            return db.Todos.Find(id);
        }
        public void EditTask(ToDo task, string title, string description, bool isDone, bool isUrgent)
        {
            task.Title = title;
            task.Description = description;
            task.IsDone = isDone;
            task.IsUrgent = isUrgent;
            db.Todos.Update(task);
            db.SaveChanges();
        }

        public List<ToDo> Search(string searchText)
        {
            return db.Todos.Where(t => t.Title.Contains(searchText) 
            || t.Description.Contains(searchText)).Include(t => t.Assignee).ToList();
        }

        public List<Assignee> ListAssignees()
        {
            return db.Assignees.ToList();
        }
        public void CreateAssignee(Assignee assignee)
        {
            db.Assignees.Add(assignee);
            db.SaveChanges();
        }
        public void DeleteAssignee(int id)
        {
            Assignee assignee = db.Assignees.Find(id);
            db.Assignees.Remove(assignee);
            db.SaveChanges();
        }

        public void EditAssignee(int id, string name, string email)
        {
            Assignee assignee = db.Assignees.Find(id);
            assignee.Name = name;
            assignee.Email = email;
            db.SaveChanges();
        }
    }
}
