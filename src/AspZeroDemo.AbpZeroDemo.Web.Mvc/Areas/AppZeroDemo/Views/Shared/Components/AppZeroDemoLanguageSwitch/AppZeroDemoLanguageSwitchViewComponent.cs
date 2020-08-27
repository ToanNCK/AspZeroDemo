using System.Linq;
using System.Threading.Tasks;
using Abp.Localization;
using Microsoft.AspNetCore.Mvc;
using AspZeroDemo.AbpZeroDemo.Web.Areas.AppZeroDemo.Models.Layout;
using AspZeroDemo.AbpZeroDemo.Web.Views;

namespace AspZeroDemo.AbpZeroDemo.Web.Areas.AppZeroDemo.Views.Shared.Components.AppZeroDemoLanguageSwitch
{
    public class AppZeroDemoLanguageSwitchViewComponent : AbpZeroDemoViewComponent
    {
        private readonly ILanguageManager _languageManager;

        public AppZeroDemoLanguageSwitchViewComponent(ILanguageManager languageManager)
        {
            _languageManager = languageManager;
        }

        public Task<IViewComponentResult> InvokeAsync(string cssClass)
        {
            var model = new LanguageSwitchViewModel
            {
                Languages = _languageManager.GetActiveLanguages().ToList(),
                CurrentLanguage = _languageManager.CurrentLanguage,
                CssClass = cssClass
            };
            
            return Task.FromResult<IViewComponentResult>(View(model));
        }
    }
}
