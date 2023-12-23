using dailyquiz.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        // builder.ToTable("Roles");
        
        // builder.Property(r => r.Name)
        //     .IsRequired()
        //     .HasMaxLength(20);
         builder.HasKey(r => r.Id);
         builder.Property(r => r.Slug).IsRequired().HasMaxLength(100);
    }
}
