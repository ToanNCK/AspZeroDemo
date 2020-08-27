using Abp.Application.Services.Dto;

namespace AspZeroDemo.AbpZeroDemo.DynamicEntityParameters.Dto
{
    public class EntityDynamicParameterDto : EntityDto
    {
        public string EntityFullName { get; set; }

        public string DynamicParameterName { get; set; }

        public int DynamicParameterId { get; set; }

        public int? TenantId { get; set; }
    }
}
