using Microsoft.AspNet.Mvc;
using Microsoft.Framework.Logging;
using System;
using WebApplicationSample.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplicationSample.Controllers
{
    public class HomeController : Controller
    {
        [Activate]
        public IDateTimeContext DateTimeContext { get; set; }

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.HelloWorld = $"{ DateTimeContext.Now }: Hello! My name is Inigo Montoya.";
            return View();
        }
    }
}
