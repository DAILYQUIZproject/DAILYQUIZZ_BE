namespace dailyquiz.Domain.Entities;

public class Category : BaseAuditableEntity
{
    public required string Name { get; set; }

    public ICollection<Question> Questions { get; set; }  = new List<Question>();// Assuming many-to-many relationship
}
