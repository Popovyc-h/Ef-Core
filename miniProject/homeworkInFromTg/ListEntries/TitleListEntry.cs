using homeworkFromTg.Base;
using homeworkFromTg.Entities;

namespace homeworkFromTg.ListEntries;

enum ListStatus
{
    FAVORITE, 
    PLANNED, 
    WATCHING, 
    DROPPED, 
    COMPLETED
}

internal class TitleListEntry : UserListEntry
{
    public Guid TitleId { get; set; }
    public Title Title { get; set; }
    public ListStatus Status { get; set; }
    public decimal Score { get; set; }
    public int Progress { get; set; }
}