using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using TypingDashboard.Authorization.Roles;
using TypingDashboard.Authorization.Users;
using TypingDashboard.MultiTenancy;
using TypingDashboard.Typings;

namespace TypingDashboard.EntityFrameworkCore
{
    public class TypingDashboardDbContext : AbpZeroDbContext<Tenant, Role, User, TypingDashboardDbContext>
    {
        public virtual DbSet<Typing> Typings { get; set; }
        
        public TypingDashboardDbContext(DbContextOptions<TypingDashboardDbContext> options)
            : base(options)
        {
        }
    }
}
