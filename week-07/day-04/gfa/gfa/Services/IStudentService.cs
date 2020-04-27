using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gfa.Services
{
    public interface IStudentService
    {
        public List<string> FindAll();
        public void Save(string student);
        public int Count();
        public string Check(string name);
    }
}
