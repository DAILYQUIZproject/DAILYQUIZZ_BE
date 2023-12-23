using dailyquiz.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class VoteConfiguration : IEntityTypeConfiguration<Vote>
{
    public void Configure(EntityTypeBuilder<Vote> builder)
    {
        builder.ToTable("Votes");

        builder.HasKey(v => v.Id);
        
        builder.Property(v => v.Upvote).IsRequired();

       builder.HasOne(v => v.User)
               .WithMany(u => u.Votes)
               .HasForeignKey(v => v.UserId)
               .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(v => v.Question)
               .WithMany(q => q.Votes)
               .HasForeignKey(v => v.QuestionId)
               .OnDelete(DeleteBehavior.Cascade);
    }
}
