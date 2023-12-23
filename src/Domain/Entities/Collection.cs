namespace dailyquiz.Domain.Entities;

public class Collection : BaseAuditableEntity
{
    public required string Title  { get; set; }

    public ICollection<Category> Categories { get; set; }  = new List<Category>();

}
