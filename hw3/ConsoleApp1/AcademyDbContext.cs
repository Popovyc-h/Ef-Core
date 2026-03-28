using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1;

public class AcademyDbContext : DbContext
{
    public DbSet<CourseDetail> CourseDetails => Set<CourseDetail>();
    public DbSet<Student> Students => Set<Student>();
    public DbSet<Course> Courses => Set<Course>();
    public DbSet<Instructor> Instructors => Set<Instructor>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseSqlServer("Server=localhost;Database=hw3Db;User Id=sa;Password=Password123$;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // ВАШ КОД ТУТ (Крок 3):
        modelBuilder.Entity<Instructor>().HasData
            (
            new Instructor { Id = 1, Name = "Alisa" },
            new Instructor { Id = 2, Name = "John" },
            new Instructor { Id = 3, Name = "Bob" },
            new Instructor { Id = 4, Name = "Oleg" }
            );
        // щоб додати хоча б одного викладача під час створення БД.

        // Завдання для терміналу (Крок 4):
        // Створіть нову міграцію "AddStudentsAndDetails" та оновіть базу.
    }
}