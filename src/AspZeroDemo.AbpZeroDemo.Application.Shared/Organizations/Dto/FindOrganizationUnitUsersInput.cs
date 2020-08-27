using AspZeroDemo.AbpZeroDemo.Dto;

namespace AspZeroDemo.AbpZeroDemo.Organizations.Dto
{
    public class FindOrganizationUnitUsersInput : PagedAndFilteredInputDto
    {
        public long OrganizationUnitId { get; set; }
    }
}
