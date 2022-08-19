using Abp.Authorization;
using Reproduction.Authorization.Roles;
using Reproduction.Authorization.Users;

namespace Reproduction.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
