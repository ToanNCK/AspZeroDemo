using Abp.AspNetCore.Mvc.ViewComponents;

namespace AspZeroDemo.AbpZeroDemo.Web.Views
{
    public abstract class AbpZeroDemoViewComponent : AbpViewComponent
    {
        protected AbpZeroDemoViewComponent()
        {
            LocalizationSourceName = AbpZeroDemoConsts.LocalizationSourceName;
        }
    }
}