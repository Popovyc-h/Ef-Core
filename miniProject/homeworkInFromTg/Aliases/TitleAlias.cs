using homeworkFromTg.Base;
using homeworkFromTg.Entities;

namespace homeworkFromTg.Aliases;

internal class TitleAlias : EntityAlias
{
    public Guid TitleId { get; set; }
    public Title Title { get; set; }
}