using System;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplicationSample.Controllers 
{
    public class HomeController 
    {

        [Activate]
        public ViewDataDictionary ViewData { get; set; }

        private dynamic ViewBag => new DynamicViewData((Func<ViewDataDictionary>)(() => ViewData));

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.HelloWorld = $"{ DateTime.Now }: Hello!  My name is Inigo Montoya.";
            ViewResult result = new ViewResult() {ViewData = this.ViewData};
            return result;
        }
    }
}
