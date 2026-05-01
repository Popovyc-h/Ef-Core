using homeworkFromTg.Base;

namespace homeworkFromTg.Entities;

internal class TitleSelectionItem : SelectionItem
{
    public Guid TitleId { get; set; }
    public Title Title { get; set; }
}