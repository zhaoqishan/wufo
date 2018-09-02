using Abp.Authorization;
using fuwo.Authorization.Roles;
using fuwo.Authorization.Users;

namespace fuwo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
