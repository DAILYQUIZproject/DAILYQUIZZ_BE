using System.Collections.Generic;
using dailyquiz.Domain.Entities;

public static class CategorySeed
{
    public static List<Category> GetCategories()
    {
        return new List<Category>
        {
            new Category { Id = Guid.NewGuid(), Name = "History" },
            new Category {  Id = Guid.NewGuid(),Name = "Geography" }
      
        };
    }
}
