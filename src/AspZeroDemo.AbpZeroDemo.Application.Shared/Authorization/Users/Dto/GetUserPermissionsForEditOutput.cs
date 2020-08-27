using System.Collections.Generic;
using AspZeroDemo.AbpZeroDemo.Authorization.Permissions.Dto;

namespace AspZeroDemo.AbpZeroDemo.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}