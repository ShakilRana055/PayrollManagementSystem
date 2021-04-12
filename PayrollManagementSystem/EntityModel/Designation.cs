using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollManagementSystem.EntityModel
{
    public class Designation:BaseClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
    }
}
