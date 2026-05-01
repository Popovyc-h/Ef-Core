using homeworkFromTg.Base;
using homeworkFromTg.Entities;

namespace homeworkFromTg.Resources;

internal class TitleResource : EntityResource
{
    public Guid TitleId { get; set; }
    public Title Title { get; set; }
}