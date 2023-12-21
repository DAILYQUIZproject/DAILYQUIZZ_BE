using dailyquiz.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class QuizConfiguration : IEntityTypeConfiguration<Quiz>
{
    public void Configure(EntityTypeBuilder<Quiz> builder)
    {
        builder.ToTable("Quizzes");

        builder.HasKey(q => q.Id);
        
        builder.Property(q => q.Title)
            .IsRequired()
            .HasMaxLength(100);
            
        builder.Property(q => q.CreatedDate)
            .IsRequired();
            
        builder.HasOne(q => q.User)
            .WithMany(u => u.Quizzes)
            .HasForeignKey(q => q.UserId);
            
        builder.HasMany(q => q.Questions)
            .WithOne(qn => qn.Quiz)
            .HasForeignKey(qn => qn.QuizId);
    }
}
