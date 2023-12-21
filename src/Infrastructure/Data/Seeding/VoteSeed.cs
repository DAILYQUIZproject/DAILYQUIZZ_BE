using System.Collections.Generic;
using dailyquiz.Domain.Entities;

public static class VoteSeed
{
    public static List<Vote> GetVotes()
    {
        return new List<Vote>
        {
            // new Vote {Upvote = true, UserId = 1 },
            // new Vote {  Upvote = false, UserId = 2 }
       
        };
    }
}
