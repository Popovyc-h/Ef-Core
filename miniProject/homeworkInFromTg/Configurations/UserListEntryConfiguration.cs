using homeworkFromTg.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace homeworkFromTg.Configurations;

internal class UserListEntryConfiguration : IEntityTypeConfiguration<UserListEntry>
{
    public void Configure(EntityTypeBuilder<UserListEntry> builder)
    {
        builder.UseTpcMappingStrategy();
    }
}