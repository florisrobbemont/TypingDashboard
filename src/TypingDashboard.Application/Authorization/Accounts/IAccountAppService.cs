using System.Threading.Tasks;
using Abp.Application.Services;
using TypingDashboard.Authorization.Accounts.Dto;

namespace TypingDashboard.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
