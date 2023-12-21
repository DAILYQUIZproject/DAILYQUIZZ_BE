namespace dailyquiz.Domain.Entities;

public class Quiz : BaseAuditableEntity
{
    public required string Title { get; set; }
    public DateTime CreatedDate { get; set; }

    public int UserId { get; set; }
    public required User User { get; set; }

    public ICollection<Question> Questions { get; set; } = null!;
}