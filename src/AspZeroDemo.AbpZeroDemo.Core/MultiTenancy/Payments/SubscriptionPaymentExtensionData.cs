using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.MultiTenancy;

namespace AspZeroDemo.AbpZeroDemo.MultiTenancy.Payments
{
    [Table("AppSubscriptionPaymentsExtensionData")]
    [MultiTenancySide(MultiTenancySides.Host)]
    public class SubscriptionPaymentExtensionData : Entity<long>, ISoftDelete
    {
        public long SubscriptionPaymentId { get; set; }

        public string Key { get; set; }

        public string Value { get; set; }

        public bool IsDeleted { get; set; }
    }
}
