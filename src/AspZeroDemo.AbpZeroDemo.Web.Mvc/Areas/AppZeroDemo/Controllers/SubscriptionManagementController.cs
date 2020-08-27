using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using AspZeroDemo.AbpZeroDemo.Authorization;
using AspZeroDemo.AbpZeroDemo.Web.Areas.AppZeroDemo.Models.Editions;
using AspZeroDemo.AbpZeroDemo.Web.Controllers;
using AspZeroDemo.AbpZeroDemo.Web.Session;

namespace AspZeroDemo.AbpZeroDemo.Web.Areas.AppZeroDemo.Controllers
{
    [Area("AppZeroDemo")]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Tenant_SubscriptionManagement)]
    public class SubscriptionManagementController : AbpZeroDemoControllerBase
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public SubscriptionManagementController(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<ActionResult> Index()
        {
            var loginInfo = await _sessionCache.GetCurrentLoginInformationsAsync();
            var model = new SubscriptionDashboardViewModel
            {
                LoginInformations = loginInfo
            };

            return View(model);
        }
    }
}