using System;
using System.Collections.Generic;
using dailyquiz.Domain.Entities;

public static class CommentSeed
{
    public static List<Comment> GetComments()
    {
        return new List<Comment>
        {
            // new Comment { Id = 1, Text = "Great quiz!", PostedDate = DateTime.UtcNow, UserId = 1 },
            // new Comment { Id = 2, Text = "I learned a lot.", PostedDate = DateTime.UtcNow, UserId = 2 }
        };
    }
}
