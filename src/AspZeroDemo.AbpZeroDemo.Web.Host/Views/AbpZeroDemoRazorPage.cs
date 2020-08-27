using Abp.AspNetCore.Mvc.Views;

namespace AspZeroDemo.AbpZeroDemo.Web.Views
{
    public abstract class AbpZeroDemoRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected AbpZeroDemoRazorPage()
        {
            LocalizationSourceName = AbpZeroDemoConsts.LocalizationSourceName;
        }
    }
}
