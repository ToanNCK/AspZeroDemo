using Abp.Events.Bus;

namespace AspZeroDemo.AbpZeroDemo.MultiTenancy
{
    public class RecurringPaymentsEnabledEventData : EventData
    {
        public int TenantId { get; set; }
    }
}