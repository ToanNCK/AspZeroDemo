using Abp.AspNetCore.Mvc.ViewComponents;

namespace AspZeroDemo.AbpZeroDemo.Web.Public.Views
{
    public abstract class AbpZeroDemoViewComponent : AbpViewComponent
    {
        protected AbpZeroDemoViewComponent()
        {
            LocalizationSourceName = AbpZeroDemoConsts.LocalizationSourceName;
        }
    }
}