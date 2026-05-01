using homeworkFromTg.Base;
using homeworkFromTg.Entities;

namespace homeworkFromTg.SelectionItems;

internal class CharacterSelectionItem : SelectionItem
{
    public Guid CharacterId { get; set; }
    public Character Character { get; set; }
}