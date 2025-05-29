namespace WebApplicationShopOnline.Models
{
    public class Game
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public Genre Genre { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string CoverImageUrl { get; set; } // URL обложки игры
        public bool IsWishlisted { get; set; }
    }
    public enum Genre//переделать под главную
    {
        Action,
        Adventure,
        RPG,
        Strategy,
        Simulation,
        Sports,
        Puzzle,
        Horror,
        Platformer,
        Other
    }
}
