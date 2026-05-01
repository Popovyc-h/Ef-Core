using homeworkFromTg.Base;

namespace homeworkFromTg.Comments;

internal class StaffCommentLike : CommentLike
{
    public Guid CommentId { get; set; }
    public StaffComment StaffComment { get; set; }
}