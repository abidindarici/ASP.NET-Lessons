using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lesson1MyAspNetCoreProject.Web.Controllers
{
    public class OrnekController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {

            ViewBag.name = "ahmet";
            TempData["surname"] = "yıldız";
            TempData["name"] = "osman";



            return View();
        }

        public IActionResult Index2()
        {
            return View();
        }

    }
}