using Microsoft.AspNet.Mvc;
using System;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplicationSample.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.HelloWorld = $"{ DateTime.Now }: Hello! My name is Inigo Montoya.";

            return View();
        }
    }
}
