using Abp.AutoMapper;
using AspZeroDemo.AbpZeroDemo.Organizations.Dto;

namespace AspZeroDemo.AbpZeroDemo.Models.Users
{
    [AutoMapFrom(typeof(OrganizationUnitDto))]
    public class OrganizationUnitModel : OrganizationUnitDto
    {
        public bool IsAssigned { get; set; }
    }
}