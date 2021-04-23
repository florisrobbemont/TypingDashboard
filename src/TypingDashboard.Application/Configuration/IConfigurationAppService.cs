using System.Threading.Tasks;
using TypingDashboard.Configuration.Dto;

namespace TypingDashboard.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
