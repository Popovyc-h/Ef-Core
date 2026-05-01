using homeworkFromTg.Aliases;
using homeworkFromTg.Base;
using homeworkFromTg.Comments;
using homeworkFromTg.Entities;
using homeworkFromTg.ListEntries;
using homeworkFromTg.Resources;
using homeworkFromTg.SelectionItems;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace homeworkFromTg.Date;

internal class AppDbContext : DbContext
{
    public DbSet<BasePersonEntity> BasePersonEntities { get; set; }
    public DbSet<Character> Character { get; set; }
    public DbSet<Staff> Staff { get; set; }
    public DbSet<CharacterResource> CharacterResources { get; set; }
    public DbSet<StaffResource> StaffResource { get; set; }
    public DbSet<TitleResource> TitleResource { get; set; }
    public DbSet<TitleListEntry> TitleListEntries { get; set; }
    public DbSet<StaffListEntry> StaffListEntries { get; set; }
    public DbSet<CharacterListEntry> CharacterListEntries { get; set; }
    public DbSet<TitleComment> TitleComment { get; set; }
    public DbSet<EpisodeComment> EpisodeComment { get; set; }
    public DbSet<CharacterComment> CharacterComment { get; set; }
    public DbSet<UserComment> UserComment { get; set; }
    public DbSet<SelectionComment> SelectionComment { get; set; }
    public DbSet<StaffComment> StaffComment { get; set; }
    public DbSet<TitleCommentLike> TitleCommentLike { get; set; }
    public DbSet<EpisodeCommentLike> EpisodeCommentLike { get; set; }
    public DbSet<CharacterCommentLike> CharacterCommentLike { get; set; }
    public DbSet<StaffCommentLike> StaffCommentLike { get; set; }
    public DbSet<UserCommentLike> UserCommentLike { get; set; }
    public DbSet<SelectionCommentLike> SelectionCommentLike { get; set; }
    public DbSet<TitleSelectionItem> TitleSelectionItems { get; set; }
    public DbSet<CharacterSelectionItem> CharacterSelectionItems { get; set; }
    public DbSet<TitleAlias> TitleAlias { get; set; }
    public DbSet<TagAlias> TagAlias { get; set; }
    public DbSet<CharacterAlias> CharacterAlias { get; set; }
    public DbSet<StaffAlias> StaffAliass { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=YourStrongPass123!");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        modelBuilder.Entity<Character>().HasData(
            new Character
            {
                Id = new Guid("10000000-0000-0000-0000-000000000001"),
                Name = "Alex Storm",
                NativeName = "アレックス・ストーム",
                Description = "A skilled swordsman with a mysterious past.",
                ImagePath = "/images/alex_storm.png",
                Gender = "Male",
                BloodType = "O",
                FavoritesCount = 1542,
                Age = 24,
                Birthday = new DateTime(1999, 05, 12, 0, 0, 0, DateTimeKind.Utc),
                HeigthCm = 178.5m,
                WeightKg = 72.0m
            },
            new Character
            {
                Id = new Guid("20000000-0000-0000-0000-000000000002"),
                Name = "Luna Spark",
                NativeName = "ルナ・スパーク",
                Description = "A talented healer who loves nature.",
                ImagePath = "/images/luna_spark.png",
                Gender = "Female",
                BloodType = "A",
                FavoritesCount = 2301,
                Age = 19,
                Birthday = new DateTime(2004, 11, 30, 0, 0, 0, DateTimeKind.Utc),
                HeigthCm = 165.0m,
                WeightKg = 54.2m
            });

        modelBuilder.Entity<Staff>().HasData(
            new Staff
            {
                Id = new Guid("30000000-0000-0000-0000-000000000003"),
                Name = "Kenjiro Tanaka",
                NativeName = "田中 健二郎",
                Description = "Award-winning animation director.",
                ImagePath = "/images/kenjiro_tanaka.png",
                Gender = "Male",
                BloodType = "B",
                FavoritesCount = 450,
                Birthday = new DateTime(1975, 03, 15, 0, 0, 0, DateTimeKind.Utc),
                Deathday = new DateTime(2024, 08, 20, 0, 0, 0, DateTimeKind.Utc),
                Hometown = "Tokyo, Japan"
            },
            new Staff
            {
                Id = new Guid("40000000-0000-0000-0000-000000000004"),
                Name = "Yumi Sato",
                NativeName = "佐藤 由美",
                Description = "Best-selling light novel author.",
                ImagePath = "/images/yumi_sato.png",
                Gender = "Female",
                BloodType = "AB",
                FavoritesCount = 890,
                Birthday = new DateTime(1988, 07, 22, 0, 0, 0, DateTimeKind.Utc),
                Deathday = new DateTime(2023, 12, 01, 0, 0, 0, DateTimeKind.Utc),
                Hometown = "Kyoto, Japan"
            });

    }
}