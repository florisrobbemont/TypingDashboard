using Abp.Application.Services;
using TypingDashboard.MultiTenancy.Dto;

namespace TypingDashboard.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

