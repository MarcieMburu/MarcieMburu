using Microsoft.AspNetCore.Mvc;

namespace Payment.Controllers
{
    public class Payment : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Remmiter()
        {
            ViewBag.Title = "Remmiter";
            return View();
        }
    }
}
