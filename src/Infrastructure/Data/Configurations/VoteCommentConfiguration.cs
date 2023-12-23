using dailyquiz.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class VoteCommentConfiguration : IEntityTypeConfiguration<VoteComment>
{
    public void Configure(EntityTypeBuilder<VoteComment> builder)
    {
        builder.ToTable("VoteComments");

        builder.HasKey(vc => vc.Id);
        
        builder.Property(vc => vc.Upvote).IsRequired();

          builder.HasOne(vc => vc.User)
               .WithMany(u => u.VoteComments)
               .HasForeignKey(vc => vc.UserId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(vc => vc.Comment)
               .WithMany(c => c.VoteComments)
               .HasForeignKey(vc => vc.CommentId)
               .OnDelete(DeleteBehavior.Restrict);
    }
}
