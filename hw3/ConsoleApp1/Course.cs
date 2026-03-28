namespace ConsoleApp1;

public class Course
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public int InstructorId { get; set; }
    public Instructor Instructor { get; set; } = null!;
    public CourseDetail? CourseDetail { get; set; }
    public List<Student> Students { get; set; } = new();
}