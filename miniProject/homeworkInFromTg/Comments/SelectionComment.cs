using homeworkFromTg.Base;
using homeworkFromTg.Entities;

namespace homeworkFromTg.Comments;

internal class SelectionComment : Comment
{
    public Guid SelectionId { get; set; }
    public Selection Selection { get; set; }
}