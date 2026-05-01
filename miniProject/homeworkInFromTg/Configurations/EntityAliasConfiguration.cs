using homeworkFromTg.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace homeworkFromTg.Configurations;

internal class EntityAliasConfiguration : IEntityTypeConfiguration<EntityAlias>
{
    public void Configure(EntityTypeBuilder<EntityAlias> builder)
    {
        builder.UseTpcMappingStrategy();
    }
}