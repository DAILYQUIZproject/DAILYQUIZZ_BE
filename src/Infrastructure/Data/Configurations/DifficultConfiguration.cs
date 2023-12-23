using dailyquiz.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
public class DifficultyConfiguration : IEntityTypeConfiguration<Difficulty>
{
    public void Configure(EntityTypeBuilder<Difficulty> builder)
    {
        builder.Property(d => d.Title).IsRequired().HasMaxLength(200);

        // Relationship with Question
        builder.HasOne(d => d.Question)
               .WithOne(q => q.Difficulty)
               .HasForeignKey<Difficulty>(d => d.QuestionId)
               .OnDelete(DeleteBehavior.Restrict);
    }
}
