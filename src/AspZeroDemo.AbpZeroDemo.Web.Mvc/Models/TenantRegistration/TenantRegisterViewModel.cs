using AspZeroDemo.AbpZeroDemo.Editions;
using AspZeroDemo.AbpZeroDemo.Editions.Dto;
using AspZeroDemo.AbpZeroDemo.MultiTenancy.Payments;
using AspZeroDemo.AbpZeroDemo.Security;
using AspZeroDemo.AbpZeroDemo.MultiTenancy.Payments.Dto;

namespace AspZeroDemo.AbpZeroDemo.Web.Models.TenantRegistration
{
    public class TenantRegisterViewModel
    {
        public PasswordComplexitySetting PasswordComplexitySetting { get; set; }

        public int? EditionId { get; set; }

        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }
    }
}
