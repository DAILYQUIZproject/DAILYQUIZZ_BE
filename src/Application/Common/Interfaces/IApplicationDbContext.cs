using dailyquiz.Domain.Entities;

namespace dailyquiz.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<TodoList> TodoLists { get; }

    DbSet<TodoItem> TodoItems { get; }

    DbSet<User> Users { get; }
    DbSet<Role> Roles { get; }
    DbSet<Quiz> Quizzes { get; }
    DbSet<Question> Questions { get; }
    DbSet<Category> Categories { get; }
    DbSet<Comment> Comments { get; }
    DbSet<Vote> Votes { get; }
    DbSet<VoteComment> VoteComments { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
