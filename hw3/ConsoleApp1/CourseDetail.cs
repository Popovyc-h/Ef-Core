namespace ConsoleApp1;

public class CourseDetail
{
    public int Id { get; set; }
    public string Syllabus { get; set; } = string.Empty;

    public int CourseId { get; set; }
    public Course Course { get; set; } = null!;
}