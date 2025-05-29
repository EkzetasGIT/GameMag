using WebApplicationShopOnline.Models;

namespace GameMag.Models
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = "Гость";
        public string Email { get; set; } = "guest@example.com";
        public string Password { get; set; } = "12345"; // Пароль открыто - только для теста!
        public string AvatarUrl { get; set; } = "https://avatars.mds.yandex.net/i?id=71cc67f1f3299d76b275bc76fe8cea94ce5bf39d-7086399-images-thumbs&n=13";
        public List<Game> Library { get; set; } = new();
        public List<Game> Wishlist { get; set; } = new();
    }
}
