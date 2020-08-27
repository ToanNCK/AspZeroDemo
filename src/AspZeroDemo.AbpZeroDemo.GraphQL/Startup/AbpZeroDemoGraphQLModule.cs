using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace AspZeroDemo.AbpZeroDemo.Startup
{
    [DependsOn(typeof(AbpZeroDemoCoreModule))]
    public class AbpZeroDemoGraphQLModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpZeroDemoGraphQLModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            base.PreInitialize();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }
    }
}