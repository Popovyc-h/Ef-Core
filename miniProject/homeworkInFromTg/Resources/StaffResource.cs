using homeworkFromTg.Base;
using homeworkFromTg.Entities;

namespace homeworkFromTg.Resources;

internal class StaffResource : EntityResource
{
    public Guid StaffId { get; set; }
    public Staff Staff { get; set; }
}