using dailyquiz.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class QuestionConfiguration : IEntityTypeConfiguration<Question>
{
    public void Configure(EntityTypeBuilder<Question> builder)
    {
        builder.ToTable("Questions");

        builder.HasKey(q => q.Id);

        builder.Property(q => q.Content)
            .IsRequired();

        builder.Property(q => q.CorrectAnswer)
            .IsRequired();

        builder.HasOne(q => q.Quiz)
            .WithMany(z => z.Questions)
            .HasForeignKey(q => q.QuizId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(q => q.Difficulty)
             .WithOne(d => d.Question)
             .HasForeignKey<Question>(q => q.DifficultId)
             .OnDelete(DeleteBehavior.Restrict);
        // Many-to-many relationship with Categories is set up in CategoryConfiguration
    }
}
