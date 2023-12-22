namespace dailyquiz.Domain.Entities;

public class Question : BaseAuditableEntity
{
    public required string Content { get; set; }
    public string? CorrectAnswer { get; set; }

    public Guid QuizId { get; set; }
    public required Quiz Quiz { get; set; } 

    public ICollection<Category> Categories { get; set; } = new  List<Category>();// Assuming many-to-many relationship
}