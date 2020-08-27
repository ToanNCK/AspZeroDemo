using Microsoft.Extensions.Configuration;

namespace AspZeroDemo.AbpZeroDemo.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
