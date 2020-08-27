using Abp.Domain.Services;

namespace AspZeroDemo.AbpZeroDemo
{
    public abstract class AbpZeroDemoDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected AbpZeroDemoDomainServiceBase()
        {
            LocalizationSourceName = AbpZeroDemoConsts.LocalizationSourceName;
        }
    }
}
