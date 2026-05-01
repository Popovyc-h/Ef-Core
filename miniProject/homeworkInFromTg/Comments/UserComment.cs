using homeworkFromTg.Base;
using homeworkFromTg.Entities;

namespace homeworkFromTg.Comments;

internal class UserComment : Comment
{
    public Guid ProfileUserId { get; set; }
    public ProfileUser ProfileUser { get; set; }
}