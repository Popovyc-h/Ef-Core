namespace ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        using var context = new GameContext();
        context.Database.EnsureCreated();

        var game1 = new Game
        {
            Name = "Minecraft",
            DevelopmentStudio = "Mojang Studios",
            Genre = "Sandbox",
            ReleaseDate = new DateTime(2011, 11, 18)
        };

        var game2 = new Game
        {
            Name = "The Witcher 3",
            DevelopmentStudio = "CD Projekt Red",
            Genre = "RPG",
            ReleaseDate = new DateTime(2015, 9, 20)
        };

        var game3 = new Game
        {
            Name = "GTA V",
            DevelopmentStudio = "Rockstar Games",
            Genre = "Action",
            ReleaseDate = new DateTime(2013, 2, 9)
        };

        var game4 = new Game
        {
            Name = "Cyberpunk 2077",
            DevelopmentStudio = "CD Projekt Red",
            Genre = "RPG",
            ReleaseDate = new DateTime(2020, 8, 17)
        };

        context.Games.AddRange(game1, game2, game3, game4);
        context.SaveChanges();

        var games = context.Games.ToList();

        foreach (var g in games)
            Console.WriteLine($"{g.Id} | {g.Name} | {g.DevelopmentStudio} | {g.Genre} | {g.ReleaseDate.ToString("dd.MM.yyyy")}");
    }
}
