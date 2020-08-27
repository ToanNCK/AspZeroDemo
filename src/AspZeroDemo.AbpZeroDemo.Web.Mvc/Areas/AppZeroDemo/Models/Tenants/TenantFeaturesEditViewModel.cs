using Abp.AutoMapper;
using AspZeroDemo.AbpZeroDemo.MultiTenancy;
using AspZeroDemo.AbpZeroDemo.MultiTenancy.Dto;
using AspZeroDemo.AbpZeroDemo.Web.Areas.AppZeroDemo.Models.Common;

namespace AspZeroDemo.AbpZeroDemo.Web.Areas.AppZeroDemo.Models.Tenants
{
    [AutoMapFrom(typeof (GetTenantFeaturesEditOutput))]
    public class TenantFeaturesEditViewModel : GetTenantFeaturesEditOutput, IFeatureEditViewModel
    {
        public Tenant Tenant { get; set; }
    }
}