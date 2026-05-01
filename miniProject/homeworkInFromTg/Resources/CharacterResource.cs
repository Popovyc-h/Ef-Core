using homeworkFromTg.Base;
using homeworkFromTg.Entities;

namespace homeworkFromTg.Resources;

internal class CharacterResource : EntityResource
{
    public Guid CharacterId { get; set; }
    public Character Character { get; set; }
}