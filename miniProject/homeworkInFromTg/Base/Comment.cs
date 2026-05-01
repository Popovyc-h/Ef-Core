using homeworkFromTg.Entities;

namespace homeworkFromTg.Base;

abstract class Comment
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; }
    public string Body { get; set; }
    public bool IsSpoiler { get; set; }
    public int LikesCount { get; set; }
    public string Path { get; set; }
    public DateTime CreatedAt { get; set; }
}