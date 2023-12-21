using dailyquiz.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Categories");

        builder.HasKey(c => c.Id);
        
        builder.Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(50);

        // Configuring the many-to-many relationship with Questions
        builder.HasMany(c => c.Questions)
            .WithMany(q => q.Categories)
            .UsingEntity(j => j.ToTable("QuestionCategories"));
    }
}
