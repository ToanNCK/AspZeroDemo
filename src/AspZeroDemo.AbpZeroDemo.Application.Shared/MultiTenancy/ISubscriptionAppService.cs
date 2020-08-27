using System.Threading.Tasks;
using Abp.Application.Services;

namespace AspZeroDemo.AbpZeroDemo.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task DisableRecurringPayments();

        Task EnableRecurringPayments();
    }
}
