using Abp;

namespace AspZeroDemo.AbpZeroDemo
{
    /// <summary>
    /// This class can be used as a base class for services in this application.
    /// It has some useful objects property-injected and has some basic methods most of services may need to.
    /// It's suitable for non domain nor application service classes.
    /// For domain services inherit <see cref="AbpZeroDemoDomainServiceBase"/>.
    /// For application services inherit AbpZeroDemoAppServiceBase.
    /// </summary>
    public abstract class AbpZeroDemoServiceBase : AbpServiceBase
    {
        protected AbpZeroDemoServiceBase()
        {
            LocalizationSourceName = AbpZeroDemoConsts.LocalizationSourceName;
        }
    }
}