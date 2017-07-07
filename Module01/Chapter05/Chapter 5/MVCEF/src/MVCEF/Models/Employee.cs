using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCEF.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public decimal Salary { get; set; }
    }
}
