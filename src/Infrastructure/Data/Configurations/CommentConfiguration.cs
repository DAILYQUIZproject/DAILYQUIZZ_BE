using dailyquiz.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class CommentConfiguration : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.ToTable("Comments");

        builder.HasKey(c => c.Id);
        
        builder.Property(c => c.Text)
            .IsRequired();
            
        builder.Property(c => c.PostedDate)
            .IsRequired();

        builder.HasOne(c => c.User)
            .WithMany(u => u.Comments)
            .HasForeignKey(c => c.UserId);

        builder.HasMany(c => c.VoteComments)
            .WithOne(vc => vc.Comment)
            .HasForeignKey(vc => vc.CommentId);
    }
}
