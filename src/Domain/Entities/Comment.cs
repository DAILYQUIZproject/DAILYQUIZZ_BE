namespace dailyquiz.Domain.Entities;

public class Comment : BaseAuditableEntity
{
    public required string Text { get; set; }
    public DateTime PostedDate { get; set; }

    public Guid UserId { get; set; }
    public required User User { get; set; }

    public ICollection<VoteComment> VoteComments { get; set; } = new List<VoteComment>();
}
