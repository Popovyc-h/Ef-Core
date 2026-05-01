using homeworkFromTg.Base;

namespace homeworkFromTg.Comments;

internal class SelectionCommentLike : CommentLike
{
    public Guid CommentId { get; set; }
    public SelectionComment SelectionComment { get; set; }
}