using Abp.AutoMapper;
using AspZeroDemo.AbpZeroDemo.Authorization.Roles.Dto;
using AspZeroDemo.AbpZeroDemo.Web.Areas.AppZeroDemo.Models.Common;

namespace AspZeroDemo.AbpZeroDemo.Web.Areas.AppZeroDemo.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class CreateOrEditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool IsEditMode => Role.Id.HasValue;
    }
}