using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AspZeroDemo.AbpZeroDemo.Authorization;

namespace AspZeroDemo.AbpZeroDemo
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(AbpZeroDemoApplicationSharedModule),
        typeof(AbpZeroDemoCoreModule)
        )]
    public class AbpZeroDemoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpZeroDemoApplicationModule).GetAssembly());
        }
    }
}