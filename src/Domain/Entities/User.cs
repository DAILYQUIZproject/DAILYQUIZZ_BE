namespace dailyquiz.Domain.Entities;

public class User : BaseAuditableEntity
{
     public required string Username { get; set; }
    public required string Email { get; set; }
    public required string PasswordHash { get; set; }

    public Guid RoleId { get; set; }
    public required Role Role { get; set; } 

    public ICollection<Quiz> Quizzes { get; set; } = new List<Quiz>(); 
    public ICollection<Vote> Votes { get; set; } = new List<Vote>(); 
    public ICollection<Comment> Comments { get; set; } = new List<Comment>() ; 

}
