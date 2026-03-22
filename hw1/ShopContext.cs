namespace ConsoleApp1;

using Microsoft.EntityFrameworkCore;

public class ShopContext : DbContext
{
    public DbSet<Product> Products => Set<Product>();

    protected override void OnConfiguring(DbContextOptionsBuilder options)
   => options.UseSqlServer( "Server=localhost;Database=ShopDb;User Id=sa;Password=Password123$;TrustServerCertificate=True;" );
}
