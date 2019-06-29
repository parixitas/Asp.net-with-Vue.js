using Microsoft.AspNetCore.Mvc;
using test.DotNetCore.HelloWorld.Models;
using System.Diagnostics;

namespace test.DotNetCore.HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
      
        public IActionResult HelloWorld()
        {
            ViewData["Message"] = string.Empty;

            return View();
        }

        [HttpPost]
        [Route("~/Home/EmployeeIndex")]
        public IActionResult EmployeeIndex([FromBody]Employee employee)
        {
            /// Save: employee
            return View();
        }
        [HttpGet]
        public IActionResult EmployeeIndex()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
