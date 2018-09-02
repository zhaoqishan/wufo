using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using fuwo.Authorization.Roles;
using fuwo.Authorization.Users;
using fuwo.MultiTenancy;

namespace fuwo.EntityFrameworkCore
{
    public class fuwoDbContext : AbpZeroDbContext<Tenant, Role, User, fuwoDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public fuwoDbContext(DbContextOptions<fuwoDbContext> options)
            : base(options)
        {
        }
    }
}
