using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace TypingDashboard.EntityFrameworkCore
{
    public static class TypingDashboardDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<TypingDashboardDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<TypingDashboardDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
