using System.Reflection;
using dailyquiz.Application.Common.Interfaces;
using dailyquiz.Domain.Entities;
using dailyquiz.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace dailyquiz.Infrastructure.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<TodoList> TodoLists => Set<TodoList>();

    public DbSet<TodoItem> TodoItems => Set<TodoItem>();

    
    public new DbSet<User> Users => Set<User>();
    public new DbSet<Role> Roles => Set<Role>();
    public DbSet<Quiz> Quizzes => Set<Quiz>();
    public DbSet<Question> Questions => Set<Question>();
    public DbSet<Category> Categories => Set<Category>();
    public DbSet<Comment> Comments => Set<Comment>();
    public DbSet<Vote> Votes => Set<Vote>();
    public DbSet<VoteComment> VoteComments => Set<VoteComment>();
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(builder);
        builder.ApplyConfiguration(new UserConfiguration());
        builder.ApplyConfiguration(new RoleConfiguration());
        builder.ApplyConfiguration(new QuizConfiguration());
        builder.ApplyConfiguration(new QuestionConfiguration());
        builder.ApplyConfiguration(new CategoryConfiguration());
        builder.ApplyConfiguration(new CommentConfiguration());
        builder.ApplyConfiguration(new VoteConfiguration());
        builder.ApplyConfiguration(new VoteCommentConfiguration());

        builder.Entity<User>().HasData(UserSeed.GetUsers());
        builder.Entity<Role>().HasData(RoleSeed.GetRoles());
        builder.Entity<Quiz>().HasData(QuizSeed.GetQuizzes());
        builder.Entity<Question>().HasData(QuestionSeed.GetQuestions());
        builder.Entity<Category>().HasData(CategorySeed.GetCategories());
        builder.Entity<Comment>().HasData(CommentSeed.GetComments());
        builder.Entity<Vote>().HasData(VoteSeed.GetVotes());
        builder.Entity<VoteComment>().HasData(VoteCommentSeed.GetVoteComments());
    }
}
