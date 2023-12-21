namespace dailyquiz.Domain.Entities;

public class Category : BaseAuditableEntity
{
    public required string Name { get; set; }

    public ICollection<Question> Questions { get; set; }  = null!;// Assuming many-to-many relationship
}
