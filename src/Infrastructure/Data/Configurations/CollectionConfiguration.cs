using dailyquiz.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class CollectionConfiguration : IEntityTypeConfiguration<Collection>
{
    public void Configure(EntityTypeBuilder<Collection> builder)
    {
        builder.Property(c => c.Title).IsRequired().HasMaxLength(200);

        builder.HasMany(c => c.Categories)
               .WithOne(q => q.Collection)
               .HasForeignKey(vc => vc.CollectionId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}
