using System;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using AspZeroDemo.AbpZeroDemo.Configuration;
using AspZeroDemo.AbpZeroDemo.UiCustomization;
using AspZeroDemo.AbpZeroDemo.UiCustomization.Dto;
using AspZeroDemo.AbpZeroDemo.Web.Areas.AppZeroDemo.Views.Shared.Themes;

namespace AspZeroDemo.AbpZeroDemo.Web.Views
{
    public abstract class AbpZeroDemoRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject] public IAbpSession AbpSession { get; set; }

        [RazorInject] public IUiThemeCustomizerFactory UiThemeCustomizerFactory { get; set; }

        protected AbpZeroDemoRazorPage()
        {
            LocalizationSourceName = AbpZeroDemoConsts.LocalizationSourceName;
        }

        public async Task<UiCustomizationSettingsDto> GetTheme()
        {
            var themeCustomizer = await UiThemeCustomizerFactory.GetCurrentUiCustomizer();
            var settings = await themeCustomizer.GetUiSettings();
            return settings;
        }

        public async Task<string> GetContainerClass()
        {
            var theme = await GetTheme();
            return theme.BaseSettings.Layout.LayoutType == "fluid" ? "container-fluid" : "container";
        }
    }
}
