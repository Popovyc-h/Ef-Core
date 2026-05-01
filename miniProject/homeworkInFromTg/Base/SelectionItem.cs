using homeworkFromTg.Entities;

namespace homeworkFromTg.Base;

abstract class SelectionItem
{
    public Guid Id { get; set; }
    public Guid SelectionId { get; set; }
    public Selection Selection { get; set; }
    public int Position { get; set; }
    public DateTime AddedAt { get; set; }
}