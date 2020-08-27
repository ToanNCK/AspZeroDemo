using System.Collections.Generic;
using AspZeroDemo.AbpZeroDemo.Authorization.Permissions.Dto;

namespace AspZeroDemo.AbpZeroDemo.Authorization.Roles.Dto
{
    public class GetRoleForEditOutput
    {
        public RoleEditDto Role { get; set; }

        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}