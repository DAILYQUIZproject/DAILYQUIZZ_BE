using System.Collections.Generic;
using dailyquiz.Domain.Entities;

public static class VoteCommentSeed
{
    public static List<VoteComment> GetVoteComments()
    {
        return new List<VoteComment>
        {
            // new VoteComment {  Upvote = true, CommentId = 1 },
            // new VoteComment { Upvote = false, CommentId = 2 }
        };
    }
}
