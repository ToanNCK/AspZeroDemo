using Abp.AutoMapper;
using Abp.Organizations;

namespace AspZeroDemo.AbpZeroDemo.Web.Areas.AppZeroDemo.Models.OrganizationUnits
{
    [AutoMapFrom(typeof(OrganizationUnit))]
    public class EditOrganizationUnitModalViewModel
    {
        public long? Id { get; set; }

        public string DisplayName { get; set; }
    }
}