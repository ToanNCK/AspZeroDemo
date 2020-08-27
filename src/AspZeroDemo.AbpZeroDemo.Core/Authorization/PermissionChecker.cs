using Abp.Authorization;
using AspZeroDemo.AbpZeroDemo.Authorization.Roles;
using AspZeroDemo.AbpZeroDemo.Authorization.Users;

namespace AspZeroDemo.AbpZeroDemo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
