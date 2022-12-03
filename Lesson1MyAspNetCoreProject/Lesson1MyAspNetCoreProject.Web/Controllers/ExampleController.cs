using Microsoft.AspNetCore.Mvc;

namespace Lesson1MyAspNetCoreProject.Web.Properties
{
    public class ExampleController : Controller
    {
        public IActionResult Index()
        {
            return View();

        }



        public IActionResult NoLayout()
        {
            return View();
        } 
    }



   

}

