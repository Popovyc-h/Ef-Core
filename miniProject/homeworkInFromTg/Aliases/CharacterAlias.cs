using homeworkFromTg.Base;
using homeworkFromTg.Entities;

namespace homeworkFromTg.Aliases;

internal class CharacterAlias : EntityAlias
{
    public Guid CharacterId { get; set; }
    public Character Character { get; set; }
}