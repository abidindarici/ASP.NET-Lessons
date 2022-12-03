using Microsoft.AspNetCore.Mvc;

namespace Lesson1MyAspNetCoreProject.Web.Controllers
{

    public class Product
    {

        public int Id { get; set; }
        public string? Name { get; set; }

    }







    public class OrnekController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var productlist = new List<Product>()
            {
                new(){ Id =1, Name="Kalem"},
                new(){ Id =2, Name="Defter"},
                new(){ Id =3, Name="Silgi"}
            };
            return View(productlist);
        }

        public IActionResult Index2()
        {
            return View();
        }

    }
}