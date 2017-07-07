using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Validation.Models;
using Validation.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Validation.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: /<controller>/        
        public IActionResult Index()
        {
            EmployeeAddViewModel employeeAddViewModel = new EmployeeAddViewModel();
            using (var db = new EmployeeDbContext())
            {
                employeeAddViewModel.EmployeesList = db.Employees.ToList();
            }
            return View(employeeAddViewModel);
        }

        [HttpPost]
        public IActionResult Index(EmployeeAddViewModel employeeAddViewModel)
        {
            if (ModelState.IsValid)
            {
                using (var db = new EmployeeDbContext())
                {
                    Employee newEmployee = new Employee
                    {
                        Name = employeeAddViewModel.Name,
                        Designation = employeeAddViewModel.Designation,
                        Salary = employeeAddViewModel.Salary
                    };
                    db.Employees.Add(newEmployee);
                    db.SaveChanges();
                    //Redirect to get Index GET method
                    return RedirectToAction("Index");
                }
            }            
            using (var db = new EmployeeDbContext())
            {
                employeeAddViewModel.EmployeesList = db.Employees.ToList();
            }
            return View(employeeAddViewModel);


        }
    }
}
