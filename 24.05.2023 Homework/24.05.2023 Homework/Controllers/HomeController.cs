using Microsoft.AspNetCore.Mvc;
namespace _24._05._2023_Homework.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Ali";
            ViewBag.Surname = "Aliyev";
            ViewBag.Age = 25;
            ViewBag.Country = "Azərbaycan";
            ViewBag.PhoneNumber = "+994551234567";
            return View();
        }
    }
}