using System.Collections.Generic;
using dailyquiz.Domain.Entities;

public static class RoleSeed
{
    public static List<Role> GetRoles()
    {
        return new List<Role>
        {
            new Role {  Name = "Admin" },
            new Role {  Name = "User" },
             new Role {  Name = "Guest" }
        };
    }
}
