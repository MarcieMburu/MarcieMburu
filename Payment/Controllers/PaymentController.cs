using Microsoft.AspNetCore.Mvc;
using Payment.Data;

namespace Payment.Controllers
{
    public class Payment : Controller

    {
        private readonly PaymentContext _context;
        public Payment (PaymentContext context)
        {
            _context = context;
        }
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
