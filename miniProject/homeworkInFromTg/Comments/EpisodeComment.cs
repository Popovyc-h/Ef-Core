using homeworkFromTg.Base;
using homeworkFromTg.Entities;

namespace homeworkFromTg.Comments;

internal class EpisodeComment : Comment
{
    public Guid EpisodeId{ get; set; }
    public Episode Episode { get; set; }
}