using Abp.Modules;
using Abp.Reflection.Extensions;

namespace AspZeroDemo.AbpZeroDemo
{
    public class AbpZeroDemoCoreSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpZeroDemoCoreSharedModule).GetAssembly());
        }
    }
}