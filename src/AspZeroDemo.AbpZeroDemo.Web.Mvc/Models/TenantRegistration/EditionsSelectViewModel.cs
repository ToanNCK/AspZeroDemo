using Abp.AutoMapper;
using AspZeroDemo.AbpZeroDemo.MultiTenancy.Dto;

namespace AspZeroDemo.AbpZeroDemo.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(EditionsSelectOutput))]
    public class EditionsSelectViewModel : EditionsSelectOutput
    {
    }
}
