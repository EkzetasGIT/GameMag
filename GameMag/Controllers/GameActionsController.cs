using GameMag.Data;
using Microsoft.AspNetCore.Mvc;

namespace GameMag.Controllers
{
    public class GameActionsController : Controller
{
    [HttpPost]
    public IActionResult Purchase(Guid gameId)
    {
        var game = GameRepository.GetGameById(gameId);
        if (game != null)
        {
            UserService.AddToLibrary(game);
            TempData["Message"] = $"Игра {game.Name} добавлена в вашу библиотеку!";
        }
        return RedirectToAction("Index", "Home");
    }

    [HttpPost]
    public IActionResult ToggleWishlist(Guid gameId)
    {
        var game = GameRepository.GetGameById(gameId);
        if (game != null)
        {
            UserService.ToggleWishlist(game);
            TempData["Message"] = UserService.HasInWishlist(gameId) 
                ? $"Игра {game.Name} добавлена в желаемое" 
                : $"Игра {game.Name} удалена из желаемого";
        }
        return RedirectToAction("Index", "Home");
    }
}
}
