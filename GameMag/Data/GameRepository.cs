using WebApplicationShopOnline.Models;

public static class GameRepository
{
    private static readonly List<Game> _games = new()
{
    new Game {
        Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
        Name = "Cyberpunk 2077",
        Genre = Genre.RPG,
        Price = 59.99m,
        CoverImageUrl = "https://image.api.playstation.com/vulcan/ap/rnd/202102/2317/TcHRODgS1MUkt1GXh4wUmuXG.png",
        Description = "Открытый мир будущего с продвинутым RPG-геймплеем"
    },
    new Game {
        Id = Guid.Parse("22222222-2222-2222-2222-222222222222"),
        Name = "The Witcher 3: Wild Hunt",
        Genre = Genre.RPG,
        Price = 39.99m,
        CoverImageUrl = "https://image.api.playstation.com/vulcan/ap/rnd/202009/2419/e7bX8hOJV7J9dUDVJjQ3KZ4J.png",
        Description = "Эпическая RPG о ведьмаке Геральте из Ривии"
    },
    new Game {
        Id = Guid.Parse("33333333-3333-3333-3333-333333333333"),
        Name = "DOOM Eternal",
        Genre = Genre.Action,
        Price = 49.99m,
        CoverImageUrl = "https://image.api.playstation.com/vulcan/ap/rnd/202007/0222/4Ki1nspqMkXyTm0b0WQMb3wV.png",
        Description = "Хардкорный шутер с демоническими силами"
    },
    new Game {
        Id = Guid.Parse("44444444-4444-4444-4444-444444444444"),
        Name = "Stardew Valley",
        Genre = Genre.Simulation,
        Price = 14.99m,
        CoverImageUrl = "https://image.api.playstation.com/vulcan/img/rnd/202010/2618/Y8KILXTnLPrMnUfMkGtJZJ4M.png",
        Description = "Расслабляющий фермерский симулятор"
    },
    new Game {
        Id = Guid.Parse("55555555-5555-5555-5555-555555555555"),
        Name = "Resident Evil Village",
        Genre = Genre.Horror,
        Price = 59.99m,
        CoverImageUrl = "https://image.api.playstation.com/vulcan/ap/rnd/202101/0821/TxSYbmed6W1UkgVWqK2bXhJb.png",
        Description = "Ужасы в готической деревне с элементами экшена"
    },
    new Game {
        Id = Guid.Parse("66666666-6666-6666-6666-666666666666"),
        Name = "FIFA 23",
        Genre = Genre.Sports,
        Price = 69.99m,
        CoverImageUrl = "https://image.api.playstation.com/vulcan/ap/rnd/202207/1211/4xJ8XB3bi888QTLZYdl7Oi0s.png",
        Description = "Современный футбольный симулятор"
    },
    new Game {
        Id = Guid.Parse("77777777-7777-7777-7777-777777777777"),
        Name = "Civilization VI",
        Genre = Genre.Strategy,
        Price = 29.99m,
        CoverImageUrl = "https://image.api.playstation.com/vulcan/ap/rnd/202008/1420/HcLcfeQBXd9iAtzsbZwWkbxZ.png",
        Description = "Пошаговая стратегия о развитии цивилизации"
    },
    new Game {
        Id = Guid.Parse("88888888-8888-8888-8888-888888888888"),
        Name = "Portal 2",
        Genre = Genre.Puzzle,
        Price = 9.99m,
        CoverImageUrl = "https://image.api.playstation.com/vulcan/ap/rnd/202009/3021/PRfYtTZQsuj3ALppqG9YtwGI.png",
        Description = "Головоломка с порталами и черным юмором"
    },
    new Game {
        Id = Guid.Parse("99999999-9999-9999-9999-999999999999"),
        Name = "Hollow Knight",
        Genre = Genre.Platformer,
        Price = 14.99m,
        CoverImageUrl = "https://image.api.playstation.com/vulcan/ap/rnd/202008/1020/TuijJKyVAbJdE8oIz4LZMYwH.png",
        Description = "Метроидвания с красивым художественным стилем"
    },
};

    public static Game? GetGameById(Guid id)
    {
        return _games.FirstOrDefault(g => g.Id == id);
    }

    public static List<Game> GetAllGames() => _games;

    public static Dictionary<Genre, List<Game>> GetGamesByGenre()
    {
        return _games
            .GroupBy(g => g.Genre)
            .ToDictionary(g => g.Key, g => g.ToList());
    }
    public static void ToggleWishlist(Guid gameId)
    {
        var game = _games.FirstOrDefault(g => g.Id == gameId);
        if (game != null)
        {
            game.IsWishlisted = !game.IsWishlisted;
        }
    }

    public static void BuyGame(Guid gameId)
    {
        // Здесь может быть логика покупки
        Console.WriteLine($"Игра с ID {gameId} куплена");
    }
}