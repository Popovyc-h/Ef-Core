using homeworkFromTg.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace homeworkFromTg.Configurations;

internal class BasePersonEntityConfiguration : IEntityTypeConfiguration<BasePersonEntity>
{
    public void Configure(EntityTypeBuilder<BasePersonEntity> builder)
    {
        builder.UseTpcMappingStrategy();
    }
}