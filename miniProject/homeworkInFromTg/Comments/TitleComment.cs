using homeworkFromTg.Base;
using homeworkFromTg.Entities;

namespace homeworkFromTg.Comments;

internal class TitleComment : Comment
{
    public Guid TitleId { get; set; }
    public Title Title { get; set; }
}