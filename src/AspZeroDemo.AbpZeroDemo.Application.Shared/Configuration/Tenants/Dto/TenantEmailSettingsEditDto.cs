using Abp.Auditing;
using AspZeroDemo.AbpZeroDemo.Configuration.Dto;

namespace AspZeroDemo.AbpZeroDemo.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}