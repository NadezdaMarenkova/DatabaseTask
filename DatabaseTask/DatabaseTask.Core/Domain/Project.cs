using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Project
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Material { get; set; }
        public string Location { get; set; }
        public int Budget { get; set; }

        public List<Employee> Employees { get; set; } = new List<Employee>();
        public IEnumerable<Specialist> specialists { get; set; } = new List<Specialist>();

    }
}
