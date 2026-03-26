namespace ConsoleApp1;

internal class Program
{
    public static void PrintGame(Game g)
    {
        Console.WriteLine($"{g.Id} | {g.Name} | {g.DevelopmentStudio} | {g.Genre} | {g.ReleaseDate.ToString("dd.MM.yyyy")} | {g.GameMode} | {g.CopiesSold}");
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
    }
}
