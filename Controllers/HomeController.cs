using Microsoft.AspNetCore.Mvc;

namespace MyAppMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Trang chủ";
            return View();
        }
    }
}
