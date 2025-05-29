using GameMag.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GameMag.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var gamesByGenre = GameRepository.GetGamesByGenre();
            return View(gamesByGenre);
        }
    }
}