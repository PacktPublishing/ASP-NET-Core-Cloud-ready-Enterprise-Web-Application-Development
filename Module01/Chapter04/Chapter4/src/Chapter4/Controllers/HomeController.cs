using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Chapter4.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Chapter4.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index2()
        {
            ViewBag.Title = "This is Index2";
            return View();
        }

        public IActionResult Index3()
        {
            ViewBag.Title = "This is Index3";
            Person person = new Person();
            return View(person);            
        }

        [HttpPost]
        public IActionResult Index3(Person person)
        {
            return View();
        }

        public ActionResult Sample()
        {
            return ViewComponent("Simple");
            //return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ValidateAge()
        {
            ViewBag.Title = "Validate Age for voting";
            Person person1 = new Person();
            return View(person1);
        }

        [HttpPost]
        public IActionResult ValidateAge(Person person1)
        {
            if(person1.Age>=18)
            {
                ViewBag.Message = "You are eligible to Vote!";
            }
            else
            {
                ViewBag.Message = "Sorry.You are not old enough to vote!";
            }
            return View();
        }
    }
}
