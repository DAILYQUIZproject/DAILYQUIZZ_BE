using System.Collections.Generic;
using dailyquiz.Domain.Entities;

public static class RoleSeed
{
    public static List<Role> GetRoles()
    {
        return new List<Role>
        {
            new Role {  Id = Guid.NewGuid(), Name = "Admin" },
            new Role {  Id = Guid.NewGuid(), Name = "User" },
             new Role {   Id = Guid.NewGuid(),Name = "Guest" }
        };
    }
}
