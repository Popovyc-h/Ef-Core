using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp1.Migrations
{
    /// <inheritdoc />
    public partial class AddCourseStatsView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("CREATE VIEW CourseStats AS " +
                "SELECT C.Title, COUNT(Id) AS StudentCount " +
                "FROM Student AS S " +
                "JOIN CourseStudent AS CS ON S.Id = CS.StudentsId " +
                "JOIN Course AS C ON C.Id = CS.CoursesId " +
                "GROUP BY C.Title");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW CourseStats");
        }
    }
}
