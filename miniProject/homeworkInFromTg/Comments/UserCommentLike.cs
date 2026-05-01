using homeworkFromTg.Base;

namespace homeworkFromTg.Comments;

internal class UserCommentLike : CommentLike
{
    public Guid CommentId { get; set; }
    public UserComment UserComment { get; set; }
}