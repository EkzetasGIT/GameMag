using GameMag.Models;
using WebApplicationShopOnline.Models;

namespace GameMag.Data
{
    public static class UserService
    {
        public static User CurrentUser { get; } = new User
        {
            Name = "Иван Иванов",
            Email = "ivan@test.com",
            AvatarUrl = "https://avatars.mds.yandex.net/i?id=43573e8604b816b7b7c3f1205592a4bf958c7940-13013551-images-thumbs&n=13",
            Library = new List<Game>(),
            Wishlist = new List<Game>()
        };

        public static void AddToLibrary(Game game)
        {
            if (!CurrentUser.Library.Any(g => g.Id == game.Id))
            {
                CurrentUser.Library.Add(game);
            }
        }

        // Добавление в желаемое
        public static void ToggleWishlist(Game game)
        {
            var existingGame = CurrentUser.Wishlist.FirstOrDefault(g => g.Id == game.Id);
            if (existingGame != null)
            {
                CurrentUser.Wishlist.Remove(existingGame);
            }
            else
            {
                CurrentUser.Wishlist.Add(game);
            }
        }

        // Проверка, есть ли игра в библиотеке
        public static bool HasInLibrary(Guid gameId)
        {
            return CurrentUser.Library.Any(g => g.Id == gameId);
        }

        // Проверка, есть ли игра в желаемом
        public static bool HasInWishlist(Guid gameId)
        {
            return CurrentUser.Wishlist.Any(g => g.Id == gameId);
        }
    }

}

