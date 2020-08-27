using System.Collections.Generic;
using Abp.Application.Services.Dto;
using AspZeroDemo.AbpZeroDemo.Authorization.Permissions.Dto;
using AspZeroDemo.AbpZeroDemo.Web.Areas.AppZeroDemo.Models.Common;

namespace AspZeroDemo.AbpZeroDemo.Web.Areas.AppZeroDemo.Models.Users
{
    public class UsersViewModel : IPermissionsEditViewModel
    {
        public string FilterText { get; set; }

        public List<ComboboxItemDto> Roles { get; set; }

        public bool OnlyLockedUsers { get; set; }

        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}