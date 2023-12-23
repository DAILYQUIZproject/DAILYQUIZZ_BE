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

        builder.HasOne(c => c.User)
            .WithMany(u => u.Comments)
            .HasForeignKey(c => c.UserId)
            .OnDelete(DeleteBehavior.Cascade); // Restrict or NoAction to prevent cascade delete

        builder.HasMany(c => c.VoteComments)
            .WithOne(vc => vc.Comment)
            .HasForeignKey(vc => vc.CommentId)
            .OnDelete(DeleteBehavior.Cascade); // Restrict or NoAction to prevent cascade delete
    }
}
