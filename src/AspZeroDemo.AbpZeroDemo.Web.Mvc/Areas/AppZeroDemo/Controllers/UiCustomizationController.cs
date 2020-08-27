using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using AspZeroDemo.AbpZeroDemo.Authorization;
using AspZeroDemo.AbpZeroDemo.Configuration;
using AspZeroDemo.AbpZeroDemo.Web.Areas.AppZeroDemo.Models.UiCustomization;
using AspZeroDemo.AbpZeroDemo.Web.Controllers;

namespace AspZeroDemo.AbpZeroDemo.Web.Areas.AppZeroDemo.Controllers
{
    [Area("AppZeroDemo")]
    [AbpMvcAuthorize]
    public class UiCustomizationController : AbpZeroDemoControllerBase
    {
        private readonly IUiCustomizationSettingsAppService _uiCustomizationAppService;

        public UiCustomizationController(IUiCustomizationSettingsAppService uiCustomizationAppService)
        {
            _uiCustomizationAppService = uiCustomizationAppService;
        }

        public async Task<ActionResult> Index()
        {
            var model = new UiCustomizationViewModel
            {
                Theme = await SettingManager.GetSettingValueAsync(AppSettings.UiManagement.Theme),
                Settings = await _uiCustomizationAppService.GetUiManagementSettings(),
                HasUiCustomizationPagePermission = await PermissionChecker.IsGrantedAsync(AppPermissions.Pages_Administration_UiCustomization)
            };

            return View(model);
        }
    }
}