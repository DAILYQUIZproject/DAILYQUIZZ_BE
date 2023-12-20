using dailyquiz.Domain.Entities;

namespace dailyquiz.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<TodoList> TodoLists { get; }

    DbSet<TodoItem> TodoItems { get; }

    DbSet<User> User {get;}

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
