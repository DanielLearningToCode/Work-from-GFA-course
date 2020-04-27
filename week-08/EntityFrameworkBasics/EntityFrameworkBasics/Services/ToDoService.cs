using EntityFrameworkBasics.Models;
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
            return db.todos.ToList();
        }

        public List<ToDo> ReturnActiveTasks()
        {
            return db.todos.Where(t => !t.IsDone).ToList();
        }
        public void CreateTask(ToDo task)
        {
            db.todos.Add(task);
            db.SaveChanges();
        }
        public void DeleteTask(long id)
        {
            db.todos.Remove(db.todos.FirstOrDefault(t => t.Id == id));
            db.SaveChanges();
        }
        public ToDo GetTask(long id)
        {
            return db.todos.Find(id);
        }
        public void EditTask(ToDo task, string title, bool isDone, bool isUrgent)
        {
            task.Title = title;
            task.IsDone = isDone;
            task.IsUrgent = isUrgent;
            db.todos.Update(task);
            db.SaveChanges();
        }
    }
}
