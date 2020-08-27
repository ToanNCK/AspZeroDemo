using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace AspZeroDemo.AbpZeroDemo.Web.Public.Views
{
    public abstract class AbpZeroDemoRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected AbpZeroDemoRazorPage()
        {
            LocalizationSourceName = AbpZeroDemoConsts.LocalizationSourceName;
        }
    }
}
