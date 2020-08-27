using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using AspZeroDemo.AbpZeroDemo.EntityFrameworkCore;

namespace AspZeroDemo.AbpZeroDemo.HealthChecks
{
    public class AbpZeroDemoDbContextHealthCheck : IHealthCheck
    {
        private readonly DatabaseCheckHelper _checkHelper;

        public AbpZeroDemoDbContextHealthCheck(DatabaseCheckHelper checkHelper)
        {
            _checkHelper = checkHelper;
        }

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            if (_checkHelper.Exist("db"))
            {
                return Task.FromResult(HealthCheckResult.Healthy("AbpZeroDemoDbContext connected to database."));
            }

            return Task.FromResult(HealthCheckResult.Unhealthy("AbpZeroDemoDbContext could not connect to database"));
        }
    }
}
