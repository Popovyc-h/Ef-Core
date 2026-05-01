namespace homeworkFromTg.Base;

abstract class EntityAlias
{
    public Guid Id { get; set; }
    public string? Name { get; set; } = null;
    public string? LanguageCode { get; set; } = null;
    public bool IsOfficial { get; set; }
}