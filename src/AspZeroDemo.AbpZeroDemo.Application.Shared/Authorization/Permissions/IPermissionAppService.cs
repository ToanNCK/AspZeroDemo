using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AspZeroDemo.AbpZeroDemo.Authorization.Permissions.Dto;

namespace AspZeroDemo.AbpZeroDemo.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
