using homeworkFromTg.Entities;

namespace homeworkFromTg.Base;

abstract class BasePersonEntity
{
    public Guid Id { get; set; }
    public SeoMetadata SeoMetadata { get; set; }
    public string? Name { get; set; } = null;
    public string? NativeName { get; set; } = null;
    public string? Description { get; set; } = null;
    public string? ImagePath { get; set; } = null;
    public string? Gender { get; set; } = null;
    public string? BloodType { get; set; } = null;
    public int FavoritesCount { get; set; }
}