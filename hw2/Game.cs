namespace ConsoleApp1;

public class Game
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string DevelopmentStudio { get; set; } = null!;
    public string Genre { get; set; } = null!;
    public DateTime ReleaseDate { get; set; }
    public string GameMode { get; set; } = null!;
    public int CopiesSold { get; set; }
}
