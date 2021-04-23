using Abp.Application.Services;
using Abp.Domain.Repositories;
using TypingDashboard.MultiTenancy;
using TypingDashboard.Typings.Dto;

namespace TypingDashboard.Typings
{
    public class TypingAppService : AsyncCrudAppService<Tenant, TypingDto, int, PagedTypingResultRequestDto, CreateTypingDto, TypingDto>, ITypingAppService
    {
        public TypingAppService(IRepository<Tenant, int> repository) : base(repository)
        {
        }
    }
}