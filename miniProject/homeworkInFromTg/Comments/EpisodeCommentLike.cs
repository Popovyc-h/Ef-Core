using homeworkFromTg.Base;

namespace homeworkFromTg.Comments;

internal class EpisodeCommentLike : CommentLike
{
    public Guid CommentId { get; set; }
    public EpisodeComment EpisodeComment { get; set; }
}