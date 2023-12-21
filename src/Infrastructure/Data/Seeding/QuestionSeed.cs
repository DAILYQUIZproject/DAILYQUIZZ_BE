using System.Collections.Generic;
using dailyquiz.Domain.Entities;

public static class QuestionSeed
{
    public static List<Question> GetQuestions()
    {
        return new List<Question>
        {
            // new Question {  Content = "What is the capital of France?", CorrectAnswer = "Paris", QuizId = 1 },
            // new Question {  Content = "What does H2O stand for?", CorrectAnswer = "Water", QuizId = 2 }
           
        };
    }
}
