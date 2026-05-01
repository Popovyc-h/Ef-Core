using homeworkFromTg.Base;
using homeworkFromTg.Entities;

namespace homeworkFromTg.Comments;

internal class StaffComment : Comment
{
    public Guid StaffId { get; set; }
    public Staff Staff { get; set; }
}