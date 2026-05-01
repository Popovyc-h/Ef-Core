using homeworkFromTg.Base;
using homeworkFromTg.Entities;

namespace homeworkFromTg.ListEntries;

internal class StaffListEntry : UserListEntry
{
    public Guid StaffId { get; set; }
    public Staff Staff { get; set; }
}