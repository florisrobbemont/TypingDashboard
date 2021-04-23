using Abp.Authorization;
using TypingDashboard.Authorization.Roles;
using TypingDashboard.Authorization.Users;

namespace TypingDashboard.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
