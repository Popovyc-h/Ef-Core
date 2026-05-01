using homeworkFromTg.Base;

namespace homeworkFromTg.Comments;

internal class CharacterCommentLike : CommentLike
{
    public Guid CommentId { get; set; }
    public CharacterComment CharacterComment { get; set; }
}