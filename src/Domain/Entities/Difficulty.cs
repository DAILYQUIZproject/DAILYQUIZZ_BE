namespace dailyquiz.Domain.Entities;

public class Difficulty : BaseAuditableEntity
{
    public required string Title  { get; set; }
    public required Guid QuestionId { get; set; }
    public required Question Question { get; set; }
}
