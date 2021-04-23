using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TypingDashboard.Authorization;

namespace TypingDashboard
{
    [DependsOn(
        typeof(TypingDashboardCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class TypingDashboardApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<TypingDashboardAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(TypingDashboardApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
