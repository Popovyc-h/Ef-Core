using homeworkFromTg.Entities;

namespace homeworkFromTg.Base;

abstract class UserListEntry
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public User User { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}