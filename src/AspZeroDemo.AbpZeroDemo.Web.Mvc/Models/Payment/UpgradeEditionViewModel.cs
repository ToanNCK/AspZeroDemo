using System.Collections.Generic;
using AspZeroDemo.AbpZeroDemo.Editions.Dto;
using AspZeroDemo.AbpZeroDemo.MultiTenancy.Payments;

namespace AspZeroDemo.AbpZeroDemo.Web.Models.Payment
{
    public class UpgradeEditionViewModel
    {
        public EditionSelectDto Edition { get; set; }

        public PaymentPeriodType PaymentPeriodType { get; set; }

        public SubscriptionPaymentType SubscriptionPaymentType { get; set; }

        public decimal? AdditionalPrice { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}