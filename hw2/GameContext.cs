using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1;

public class GameContext : DbContext
{
    public DbSet<Game> Games => Set<Game>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseSqlServer("Server=localhost;Database=GameDb;User Id=sa;Password=Password123$;TrustServerCertificate=True;");
}