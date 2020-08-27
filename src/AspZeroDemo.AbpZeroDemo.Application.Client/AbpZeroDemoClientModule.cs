using Abp.Modules;
using Abp.Reflection.Extensions;

namespace AspZeroDemo.AbpZeroDemo
{
    public class AbpZeroDemoClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpZeroDemoClientModule).GetAssembly());
        }
    }
}
