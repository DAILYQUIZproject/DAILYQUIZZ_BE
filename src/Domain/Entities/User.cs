namespace dailyquiz.Domain.Entities;

public class User : BaseAuditableEntity
{
     public required string Username { get; set; }
    public required string Email { get; set; }
    public required string PasswordHash { get; set; }

    public int RoleId { get; set; }
    public required Role Role { get; set; } 

    public ICollection<Quiz> Quizzes { get; set; } = null! ; 
    public ICollection<Vote> Votes { get; set; } = null! ; 
    public ICollection<Comment> Comments { get; set; } = null! ; 

}
