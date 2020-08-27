using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspZeroDemo.AbpZeroDemo.Authorization.Permissions.Dto;

namespace AspZeroDemo.AbpZeroDemo.Web.Areas.AppZeroDemo.Models.Common.Modals
{
    public class PermissionTreeModalViewModel : IPermissionsEditViewModel
    {
        public List<FlatPermissionDto> Permissions { get; set; }
        public List<string> GrantedPermissionNames { get; set; }
    }
}
