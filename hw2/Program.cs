namespace ConsoleApp1;

internal class Program
{
    public static void PrintGame(Game g)
    {
        Console.WriteLine($"{g.Id} | {g.Name} | {g.DevelopmentStudio} | {g.Genre} | {g.ReleaseDate.ToString("dd.MM.yyyy")} | {g.GameMode} | {g.CopiesSold}");
    }

    public static void AddGame(GameContext context)
    {
        Console.Write("\nEnter game name: ");
        string name = Console.ReadLine();

        bool exists = context.Games.Any(g => g.Name == name);

        if (exists)
        {
            Console.WriteLine("A game with that name already exists");
            return;
        }

        Console.Write("Enter development studio: ");
        string studio = Console.ReadLine();

        Console.Write("Enter genre: ");
        string genre = Console.ReadLine();

        Console.Write("Enter release date (dd.MM.yyyy): ");
        DateTime releaseDate = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter game mode: ");
        string gameMode = Console.ReadLine();

        Console.Write("Enter copies sold: ");
        int copiesSold = int.Parse(Console.ReadLine());

        var newGame = new Game
        {
            Name = name,
            DevelopmentStudio = studio,
            Genre = genre,
            ReleaseDate = releaseDate,
            GameMode = gameMode,
            CopiesSold = copiesSold
        };

        context.Games.Add(newGame);
        context.SaveChanges();
        Console.WriteLine("Game added");
    }

    public static void UpdateGame(GameContext context)
    {
        Console.WriteLine("Game list");

        var games = context.Games.ToList();
        foreach (var g in games)
            PrintGame(g);

        Console.Write("\nEnter the name of the game you want to update: ");
        string name = Console.ReadLine();

        bool exists = context.Games.Any(g => g.Name == name);

        if (!exists)
        {
            Console.WriteLine("There is no game with that name");
            return;
        }
        
        var game = context.Games.FirstOrDefault(g => g.Name == name);

        Console.WriteLine("What do you want to change?");
        Console.WriteLine("1 - Name");
        Console.WriteLine("2 - Studio");
        Console.WriteLine("3 - Genre");
        Console.WriteLine("4 - Date");
        Console.WriteLine("5 - Mode");
        Console.WriteLine("6 - Selling");
        Console.Write("Your choice: ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Console.Write("Enter new name: ");
            string gameName = Console.ReadLine();

            game.Name = gameName;
        }
        else if (choice == 2)
        {
            Console.Write("Enter new development studio: ");
            string studio = Console.ReadLine();

            game.DevelopmentStudio = studio;
        }
        else if (choice == 3)
        {
            Console.Write("Enter new genre: ");
            string genre = Console.ReadLine();

            game.Genre = genre;
        }
        else if (choice == 4)
        {
            Console.Write("Enter new release date (dd.MM.yyyy): ");
            DateTime releaseDate = DateTime.Parse(Console.ReadLine());

            game.ReleaseDate = releaseDate;
        }
        else if (choice == 5)
        {
            Console.Write("Enter new game mode: ");
            string gameMode = Console.ReadLine();

            game.GameMode = gameMode;
        }
        else if (choice == 6)
        {
            Console.Write("Enter new copies sold: ");
            int copiesSold = int.Parse(Console.ReadLine());

            game.CopiesSold = copiesSold;
        }
        else
            Console.WriteLine("Invalid choice");
     
        context.SaveChanges();
        Console.WriteLine("Game updated!");
    }

    public static void DeleteGame(GameContext context)
    {
        Console.WriteLine("Game list");

        var games = context.Games.ToList();
        foreach (var g in games)
            PrintGame(g);

        Console.Write("\nEnter game name: ");
        string name = Console.ReadLine();

        Console.Write("Enter development studio: ");
        string developmentStudio = Console.ReadLine();

        var game = context.Games.FirstOrDefault(g => g.Name == name && g.DevelopmentStudio == developmentStudio);

        if (game == null)
        {
            Console.WriteLine("Game not found");
            return;
        }

        Console.Write("Are you sure you want to delete this game? (y/n): ");
        string confirm = Console.ReadLine();

        if (confirm == "y")
        {
            context.Games.Remove(game);
            context.SaveChanges();
            Console.WriteLine("Game deleted");
        }
        else
            Console.WriteLine("Deletion cancelled");
    }

    static void Main(string[] args)
    {
        using var context = new GameContext();
        //context.Database.EnsureCreated();

        var game1 = new Game
        {
            Name = "Minecraft",
            DevelopmentStudio = "Mojang Studios",
            Genre = "Sandbox",
            ReleaseDate = new DateTime(2011, 11, 18),
            GameMode = "Multiplayer",
            CopiesSold = 32
        };

        var game2 = new Game
        {
            Name = "The Witcher 3",
            DevelopmentStudio = "CD Projekt Red",
            Genre = "RPG",
            ReleaseDate = new DateTime(2015, 9, 20),
            GameMode = "Singleplayer",
            CopiesSold = 11
        };

        var game3 = new Game
        {
            Name = "GTA V",
            DevelopmentStudio = "Rockstar Games",
            Genre = "Action",
            ReleaseDate = new DateTime(2013, 2, 9),
            GameMode = "Singleplayer",
            CopiesSold = 139
        };

        var game4 = new Game
        {
            Name = "Cyberpunk 2077",
            DevelopmentStudio = "CD Projekt Red",
            Genre = "RPG",
            ReleaseDate = new DateTime(2020, 8, 17),
            GameMode = "Multiplayer",
            CopiesSold = 59
        };

        //context.Games.AddRange(game1, game2, game3, game4);
        //context.SaveChanges();

        var games = context.Games.ToList();

        foreach (var g in games)
            PrintGame(g);

        Console.Write("\nEnter a name to search: ");
        string nameForSearch = Console.ReadLine();

        Console.WriteLine();

        var searchByName = context.Games.Where(g => g.Name == nameForSearch).ToList();
        foreach (var s in searchByName)
            PrintGame(s);

        Console.Write("\nEnter a studio name to search: ");
        string developmentStudioForSearch = Console.ReadLine();

        Console.WriteLine();

        var searchByDevelopmentStudio = context.Games.Where(s => s.DevelopmentStudio == developmentStudioForSearch).ToList();
        foreach (var s in searchByDevelopmentStudio)
            PrintGame(s);

        Console.Write("\nEnter a name to search: ");
        string searchName = Console.ReadLine();

        Console.Write("Enter a studio name to search: ");
        string searchStudio = Console.ReadLine();

        var searchByNameAndStudio = context.Games.Where(g => g.Name == searchName && g.DevelopmentStudio == searchStudio).ToList();

        foreach (var s in searchByNameAndStudio)
            PrintGame(s);

        Console.Write("\nEnter a genre to search: ");
        string searchGenre = Console.ReadLine();

        var searchByGenre = context.Games.Where(g => g.Genre == searchGenre).ToList();
        foreach (var s in searchByGenre)
            PrintGame(s);

        Console.Write("\nEnter a year to search: ");
        int searchYear = int.Parse(Console.ReadLine());

        var searchByYear = context.Games.Where(g => g.ReleaseDate.Year == searchYear).ToList();
        foreach (var s in searchByYear)
            PrintGame(s);

        Console.WriteLine();
        var allSingleGames = context.Games.Where(g => g.GameMode == "Singleplayer").ToList();
        foreach (var a in allSingleGames)
            PrintGame(a);

        Console.WriteLine();
        var allMultiplayerGames = context.Games.Where(g => g.GameMode == "Multiplayer").ToList();
        foreach (var a in allMultiplayerGames)
            PrintGame(a);

        var maxCopiesSold = context.Games.OrderByDescending(g => g.CopiesSold).First();
        Console.WriteLine($"\nMax: {maxCopiesSold.Name} | {maxCopiesSold.CopiesSold}");

        var minCopiesSold = context.Games.OrderBy(g => g.CopiesSold).First();
        Console.WriteLine($"Min: {minCopiesSold.Name} | {minCopiesSold.CopiesSold}");

        Console.WriteLine();
        var top3BestSelling = context.Games.OrderByDescending(g => g.CopiesSold).Take(3).ToList();
        foreach (var t in top3BestSelling)
            PrintGame(t);

        Console.WriteLine();
        var top3WorstSelling = context.Games.OrderBy(g => g.CopiesSold).Take(3).ToList();
        foreach (var t in top3WorstSelling)
            PrintGame(t);

        AddGame(context);
        UpdateGame(context);
        DeleteGame(context);
    }
}