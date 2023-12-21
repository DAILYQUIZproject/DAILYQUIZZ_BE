using System.Collections.Generic;
using dailyquiz.Domain.Entities;

public static class UserSeed
{
    public static List<User> GetUsers()
    {
        return new List<User>
        {
            // new User {  Username = "user1", Email = "user1@example.com", PasswordHash = "hashedpassword1", RoleId = 1 },
            // new User {  Username = "user2", Email = "user2@example.com", PasswordHash = "hashedpassword2", RoleId = 2 }
          
        };
    }
}
