using homeworkFromTg.Base;
using homeworkFromTg.Entities;

namespace homeworkFromTg.ListEntries;

internal class CharacterListEntry : UserListEntry
{
    public Guid CharacterId { get; set; }
    public Character Character { get; set; }
}