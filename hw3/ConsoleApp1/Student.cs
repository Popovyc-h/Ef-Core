namespace ConsoleApp1;

public class Student
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public List<Course> Courses { get; set; } = new();
}