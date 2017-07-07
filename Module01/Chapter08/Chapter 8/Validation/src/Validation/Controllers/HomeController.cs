using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Validation.Controllers
{    
    [Route("Home")]
    public class HomeController : Controller
    {
        // GET: /<controller>/
        //[Route("")]
        [HttpGet()]
        public IActionResult Index()
        {
            return View();
        }

        //[Route("Index3")]
        [HttpGet("Index3")]
        public IActionResult Index2()
        {
            return Content("Index2 action method");
        }
    }
}
