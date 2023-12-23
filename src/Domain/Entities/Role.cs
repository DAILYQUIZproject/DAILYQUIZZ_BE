namespace dailyquiz.Domain.Entities;

public class Role : BaseAuditableEntity
{

    public required string Slug { get; set; }
    public ICollection<User> Users { get; set; } = new List<User>();

}