using GameMag.Data;
using Microsoft.AspNetCore.Mvc;

namespace GameMag.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Profile()
        {
            return View(UserService.CurrentUser);
        }
    }
}
