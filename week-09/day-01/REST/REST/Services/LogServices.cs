using REST.Database;
using REST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace REST.Services
{
    public class LogServices
    {
        private ApplicationDBContext db;
        public LogServices(ApplicationDBContext db)
        {
            this.db = db;
        }

        public void SaveToDatabase(Log log)
        {
            db.Logs.Add(log);
            db.SaveChanges();
        }
        public Logs GetLogEntries()
        {
            return new Logs() { EntryCount = db.Logs.Count(), Entries = db.Logs.ToList() };
        }
    }
}
