using System;
using System.Collections.Generic;
using dailyquiz.Domain.Entities;

public static class QuizSeed
{
    public static List<Quiz> GetQuizzes()
    {
        return new List<Quiz>
        {
            // new Quiz { Title = "General Knowledge", CreatedDate = DateTime.UtcNow, UserId = 1 },
            // new Quiz {  Title = "Science", CreatedDate = DateTime.UtcNow, UserId = 2 }
         
        };
    }
}
