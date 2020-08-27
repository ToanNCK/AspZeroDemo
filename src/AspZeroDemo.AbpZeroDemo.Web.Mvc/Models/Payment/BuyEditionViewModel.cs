using System.Collections.Generic;
using AspZeroDemo.AbpZeroDemo.Editions;
using AspZeroDemo.AbpZeroDemo.Editions.Dto;
using AspZeroDemo.AbpZeroDemo.MultiTenancy.Payments;
using AspZeroDemo.AbpZeroDemo.MultiTenancy.Payments.Dto;

namespace AspZeroDemo.AbpZeroDemo.Web.Models.Payment
{
    public class BuyEditionViewModel
    {
        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public decimal? AdditionalPrice { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}
