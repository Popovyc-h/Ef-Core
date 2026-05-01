namespace homeworkFromTg.Base;

enum ResourceType
{
    WIKIPEDIA_EN,
    WIKIPEDIA_JP,
    OFFICIAL_SITE,
    TWITTER,
    INSTAGRAM
}

abstract class EntityResource
{
    public Guid Id { get; set; }
    public ResourceType Type { get; set; }
    public string Url { get; set; }
}