using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using TypingDashboard.Authorization.Users;
using TypingDashboard.Editions;

namespace TypingDashboard.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
