using Microsoft.Extensions.DependencyInjection;
using AspZeroDemo.AbpZeroDemo.HealthChecks;

namespace AspZeroDemo.AbpZeroDemo.Web.HealthCheck
{
    public static class AbpZeroHealthCheck
    {
        public static IHealthChecksBuilder AddAbpZeroHealthCheck(this IServiceCollection services)
        {
            var builder = services.AddHealthChecks();
            builder.AddCheck<AbpZeroDemoDbContextHealthCheck>("Database Connection");
            builder.AddCheck<AbpZeroDemoDbContextUsersHealthCheck>("Database Connection with user check");
            builder.AddCheck<CacheHealthCheck>("Cache");

            // add your custom health checks here
            // builder.AddCheck<MyCustomHealthCheck>("my health check");

            return builder;
        }
    }
}
