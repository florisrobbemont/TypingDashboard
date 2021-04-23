using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace TypingDashboard.Controllers
{
    public abstract class TypingDashboardControllerBase: AbpController
    {
        protected TypingDashboardControllerBase()
        {
            LocalizationSourceName = TypingDashboardConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
