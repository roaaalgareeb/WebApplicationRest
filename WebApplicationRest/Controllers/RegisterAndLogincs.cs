using Microsoft.AspNetCore.Mvc;

namespace WebApplicationRest.Controllers
{
    public class RegisterAndLogincs : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
    }
}
