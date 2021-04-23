using System.Threading.Tasks;
using Abp.Application.Services;
using TypingDashboard.Sessions.Dto;

namespace TypingDashboard.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
