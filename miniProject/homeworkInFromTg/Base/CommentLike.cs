using homeworkFromTg.Entities;

namespace homeworkFromTg.Base;

abstract class CommentLike
{
    public Guid CommentId { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; }
    public bool IsLiked { get; set; }
}