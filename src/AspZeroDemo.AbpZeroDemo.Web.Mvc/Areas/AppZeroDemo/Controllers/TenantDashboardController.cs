using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using AspZeroDemo.AbpZeroDemo.Authorization;
using AspZeroDemo.AbpZeroDemo.DashboardCustomization;
using AspZeroDemo.AbpZeroDemo.Web.DashboardCustomization;
using System.Threading.Tasks;

namespace AspZeroDemo.AbpZeroDemo.Web.Areas.AppZeroDemo.Controllers
{
    [Area("AppZeroDemo")]
    [AbpMvcAuthorize(AppPermissions.Pages_Tenant_Dashboard)]
    public class TenantDashboardController : CustomizableDashboardControllerBase
    {
        public TenantDashboardController(DashboardViewConfiguration dashboardViewConfiguration, 
            IDashboardCustomizationAppService dashboardCustomizationAppService) 
            : base(dashboardViewConfiguration, dashboardCustomizationAppService)
        {

        }

        public async Task<ActionResult> Index()
        {
            return await GetView(AbpZeroDemoDashboardCustomizationConsts.DashboardNames.DefaultTenantDashboard);
        }
    }
}