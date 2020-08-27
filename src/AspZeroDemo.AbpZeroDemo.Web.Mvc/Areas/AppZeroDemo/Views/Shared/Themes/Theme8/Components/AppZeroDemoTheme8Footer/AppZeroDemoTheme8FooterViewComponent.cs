using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspZeroDemo.AbpZeroDemo.Web.Areas.AppZeroDemo.Models.Layout;
using AspZeroDemo.AbpZeroDemo.Web.Session;
using AspZeroDemo.AbpZeroDemo.Web.Views;

namespace AspZeroDemo.AbpZeroDemo.Web.Areas.AppZeroDemo.Views.Shared.Themes.Theme8.Components.AppZeroDemoTheme8Footer
{
    public class AppZeroDemoTheme8FooterViewComponent : AbpZeroDemoViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppZeroDemoTheme8FooterViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var footerModel = new FooterViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(footerModel);
        }
    }
}
