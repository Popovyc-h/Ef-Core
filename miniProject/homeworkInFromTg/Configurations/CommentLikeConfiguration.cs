using homeworkFromTg.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace homeworkFromTg.Configurations;

internal class CommentLikeConfiguration : IEntityTypeConfiguration<CommentLike>
{
    public void Configure(EntityTypeBuilder<CommentLike> builder)
    {
        builder.UseTpcMappingStrategy();
        builder.HasKey(x => new { x.CommentId, x.UserId });
    }
}