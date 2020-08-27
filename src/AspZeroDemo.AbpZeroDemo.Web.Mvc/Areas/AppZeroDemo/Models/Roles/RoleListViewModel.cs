using System.Collections.Generic;
using Abp.Application.Services.Dto;
using AspZeroDemo.AbpZeroDemo.Authorization.Permissions.Dto;
using AspZeroDemo.AbpZeroDemo.Web.Areas.AppZeroDemo.Models.Common;

namespace AspZeroDemo.AbpZeroDemo.Web.Areas.AppZeroDemo.Models.Roles
{
    public class RoleListViewModel : IPermissionsEditViewModel
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}