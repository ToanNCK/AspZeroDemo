using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace AspZeroDemo.AbpZeroDemo
{
    [DependsOn(typeof(AbpZeroDemoClientModule), typeof(AbpAutoMapperModule))]
    public class AbpZeroDemoXamarinSharedModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpZeroDemoXamarinSharedModule).GetAssembly());
        }
    }
}