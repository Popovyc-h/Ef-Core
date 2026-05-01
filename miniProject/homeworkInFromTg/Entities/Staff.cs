using homeworkFromTg.Base;

namespace homeworkFromTg.Entities;

internal class Staff : BasePersonEntity
{
    public DateTime Birthday { get; set; }
    public DateTime Deathday { get; set; }
    public string? Hometown { get; set; } = null;
}