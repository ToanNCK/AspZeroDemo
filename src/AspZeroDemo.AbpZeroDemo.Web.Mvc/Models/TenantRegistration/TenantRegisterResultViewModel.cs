using Abp.AutoMapper;
using AspZeroDemo.AbpZeroDemo.MultiTenancy.Dto;

namespace AspZeroDemo.AbpZeroDemo.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(RegisterTenantOutput))]
    public class TenantRegisterResultViewModel : RegisterTenantOutput
    {
        public string TenantLoginAddress { get; set; }
    }
}