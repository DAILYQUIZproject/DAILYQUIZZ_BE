namespace dailyquiz.Domain.Entities;

public class Category : BaseAuditableEntity
{
    public required string Title  { get; set; }

    public required Guid CollectionId {get ; set;}
    public required Collection Collection {get ; set;} 
    public ICollection<Question> Questions { get; set; }  = new List<Question>();// Assuming many-to-many relationship
}
