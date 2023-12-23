namespace dailyquiz.Domain.Entities;

public class VoteComment : BaseAuditableEntity
{
    public bool Upvote { get; set; }

    public Guid UserId {get ; set ;}
    public required User User {get ; set ;}
    public Guid CommentId { get; set; }
    public required Comment Comment { get; set; }
}
