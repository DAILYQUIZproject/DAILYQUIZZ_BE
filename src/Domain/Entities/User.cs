namespace dailyquiz.Domain.Entities;

public class User : BaseAuditableEntity
{
    public int ID { get; set; }
    public required string UserName { get; set; }

    public required string Password { get; set; }

    public required string Email { get; set; }

    public Role roles { get; set; } = Role.FreeUser;

}
