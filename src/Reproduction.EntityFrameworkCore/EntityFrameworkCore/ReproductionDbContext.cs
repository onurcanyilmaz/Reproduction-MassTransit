using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Reproduction.Authorization.Roles;
using Reproduction.Authorization.Users;
using Reproduction.MultiTenancy;

namespace Reproduction.EntityFrameworkCore
{
    public class ReproductionDbContext : AbpZeroDbContext<Tenant, Role, User, ReproductionDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ReproductionDbContext(DbContextOptions<ReproductionDbContext> options)
            : base(options)
        {
        }
    }
}
