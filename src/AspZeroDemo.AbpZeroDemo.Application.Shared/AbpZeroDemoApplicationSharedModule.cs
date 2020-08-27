using Abp.Modules;
using Abp.Reflection.Extensions;

namespace AspZeroDemo.AbpZeroDemo
{
    [DependsOn(typeof(AbpZeroDemoCoreSharedModule))]
    public class AbpZeroDemoApplicationSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpZeroDemoApplicationSharedModule).GetAssembly());
        }
    }
}