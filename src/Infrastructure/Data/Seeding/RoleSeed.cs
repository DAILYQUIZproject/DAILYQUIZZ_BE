using System.Collections.Generic;
using dailyquiz.Domain.Entities;

public static class RoleSeed
{
    public static List<Role> GetRoles()
    {
        return new List<Role>
        {
            // new Role {  Id = Guid.NewGuid(), Slug = "Admin" },
            // new Role {  Id = Guid.NewGuid(), Slug = "User" },
            //  new Role {   Id = Guid.NewGuid(),Slug = "Guest" }
        };
    }
}
