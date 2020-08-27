using Abp.Modules;
using Abp.Reflection.Extensions;

namespace AspZeroDemo.AbpZeroDemo
{
    [DependsOn(typeof(AbpZeroDemoXamarinSharedModule))]
    public class AbpZeroDemoXamarinIosModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpZeroDemoXamarinIosModule).GetAssembly());
        }
    }
}