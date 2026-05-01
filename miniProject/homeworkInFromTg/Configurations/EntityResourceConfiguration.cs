using homeworkFromTg.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace homeworkFromTg.Configurations;

internal class EntityResourceConfiguration : IEntityTypeConfiguration<EntityResource>
{
    public void Configure(EntityTypeBuilder<EntityResource> builder)
    {
        builder.UseTpcMappingStrategy();
    }
}