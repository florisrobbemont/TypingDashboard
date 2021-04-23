using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TypingDashboard.Configuration;

namespace TypingDashboard.Web.Host.Startup
{
    [DependsOn(
       typeof(TypingDashboardWebCoreModule))]
    public class TypingDashboardWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public TypingDashboardWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TypingDashboardWebHostModule).GetAssembly());
        }
    }
}
