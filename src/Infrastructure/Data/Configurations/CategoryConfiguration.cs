using dailyquiz.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable("Categories");

        builder.HasKey(c => c.Id);

        // // Configuring the many-to-many relationship with Questions
        // builder.HasMany(c => c.Questions)
        //     .WithMany(q => q.Categories)
        //     .UsingEntity(j => j.ToTable("QuestionCategories"));

           builder.Property(c => c.Title).IsRequired().HasMaxLength(200);

        // Many-to-Many: Category to Question
        builder.HasMany(c => c.Questions)
               .WithMany(q => q.Categories);
    }
}
