using homeworkFromTg.Base;
using homeworkFromTg.Entities;

namespace homeworkFromTg.Comments;

internal class CharacterComment : Comment
{
    public Guid CharacterId { get; set; }
    public Character Character { get; set; }
}