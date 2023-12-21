using System.Collections.Generic;
using dailyquiz.Domain.Entities;

public static class CategorySeed
{
    public static List<Category> GetCategories()
    {
        return new List<Category>
        {
            new Category { Name = "History" },
            new Category { Name = "Geography" }
      
        };
    }
}
