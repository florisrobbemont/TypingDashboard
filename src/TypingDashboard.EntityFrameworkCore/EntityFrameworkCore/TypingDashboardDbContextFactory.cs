using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using TypingDashboard.Configuration;
using TypingDashboard.Web;

namespace TypingDashboard.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class TypingDashboardDbContextFactory : IDesignTimeDbContextFactory<TypingDashboardDbContext>
    {
        public TypingDashboardDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<TypingDashboardDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            TypingDashboardDbContextConfigurer.Configure(builder, configuration.GetConnectionString(TypingDashboardConsts.ConnectionStringName));

            return new TypingDashboardDbContext(builder.Options);
        }
    }
}
