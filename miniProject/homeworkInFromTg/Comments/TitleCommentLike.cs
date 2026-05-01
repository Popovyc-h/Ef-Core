using homeworkFromTg.Base;

namespace homeworkFromTg.Comments;

internal class TitleCommentLike : CommentLike
{
    public Guid CommentId { get; set; }
    public TitleComment TitleComment { get; set; }
}