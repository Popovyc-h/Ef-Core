using homeworkFromTg.Base;
using homeworkFromTg.Entities;

namespace homeworkFromTg.Aliases;

internal class TagAlias : EntityAlias
{
    public Guid TagId { get; set; }
    public Tag Tag { get; set; }
}