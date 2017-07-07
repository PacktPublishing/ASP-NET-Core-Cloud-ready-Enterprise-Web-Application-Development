using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using MVCEF.Models;
using MVCEF.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCEF.Controllers
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
                employeeAddViewModel.NewEmployee = new Employee();

            }
            return View(employeeAddViewModel);
        }

        [HttpPost]
        public IActionResult Index(EmployeeAddViewModel employeeAddViewModel)
        {
           
            using (var db = new EmployeeDbContext())
            {
                db.Employees.Add(employeeAddViewModel.NewEmployee);
                db.SaveChanges();
                //Redirect to get Index GET method
                return RedirectToAction("Index");                
            }

        }
    }
}
