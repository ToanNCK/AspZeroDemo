using Abp.AutoMapper;
using AspZeroDemo.AbpZeroDemo.Sessions.Dto;

namespace AspZeroDemo.AbpZeroDemo.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}