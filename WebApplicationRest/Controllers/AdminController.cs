using Microsoft.AspNetCore.Mvc;

namespace WebApplicationRest.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Table()
        {
            return View();
        }
        public IActionResult Billing()
        {
            return View();
        }
        public IActionResult Notification()
        {
            return View();
        }
        public IActionResult Profile()
        {
            return View();
        }

    }
}
