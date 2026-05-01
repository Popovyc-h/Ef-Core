using homeworkFromTg.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace homeworkFromTg.Configurations;

internal class SelectionItemConfiguration : IEntityTypeConfiguration<SelectionItem>
{
    public void Configure(EntityTypeBuilder<SelectionItem> builder)
    {
        builder.UseTpcMappingStrategy();
    }
}