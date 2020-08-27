using Abp.Modules;
using Abp.Reflection.Extensions;

namespace AspZeroDemo.AbpZeroDemo
{
    [DependsOn(typeof(AbpZeroDemoXamarinSharedModule))]
    public class AbpZeroDemoXamarinAndroidModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpZeroDemoXamarinAndroidModule).GetAssembly());
        }
    }
}