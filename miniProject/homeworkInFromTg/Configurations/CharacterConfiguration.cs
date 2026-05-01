using homeworkFromTg.Base;
using homeworkFromTg.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace homeworkFromTg.Configurations;

internal class CharacterConfiguration : IEntityTypeConfiguration<Character>
{
    public void Configure(EntityTypeBuilder<Character> builder)
    {
        builder.OwnsOne(x => x.SeoMetadata);
    }
}