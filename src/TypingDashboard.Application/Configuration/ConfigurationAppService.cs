using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using TypingDashboard.Configuration.Dto;

namespace TypingDashboard.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TypingDashboardAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
