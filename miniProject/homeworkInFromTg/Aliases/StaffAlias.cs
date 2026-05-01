using homeworkFromTg.Base;
using homeworkFromTg.Entities;

namespace homeworkFromTg.Aliases;

internal class StaffAlias : EntityAlias
{
    public Guid StaffId { get; set; }
    public Staff Staff { get; set; }
}