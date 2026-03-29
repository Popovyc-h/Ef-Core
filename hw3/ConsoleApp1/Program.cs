using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1;

internal class Program
{
    public static async Task<List<Instructor>> GetFullAcademyDataAsync(AcademyDbContext db)
    {
        // ВАШ КОД ТУТ (Крок 1):
        // Напишіть запит, який дістає всіх викладачів.
        // Використайте .Include() щоб підтягнути їхні Courses.
        // Використайте .ThenInclude() щоб для кожного курсу підтягнути CourseDetail.
        // Використайте ще один .Include() або .ThenInclude() для підтягування Students на курсах.

        return await db.Instructors
            .Include(I => I.Courses)
            .ThenInclude(c => c.CourseDetail)
            .Include(i => i.Courses)
            .ThenInclude(c => c.Students)
            .ToListAsync();
}

    static void Main(string[] args)
    {

    }
}