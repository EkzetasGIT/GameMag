using Microsoft.AspNetCore.Mvc;

namespace GameMag.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
