using MVCEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCEF.ViewModels
{
    public class EmployeeAddViewModel
    {
        public List<Employee> EmployeesList { get; set; }
        public Employee NewEmployee { get; set; }
    }
}
