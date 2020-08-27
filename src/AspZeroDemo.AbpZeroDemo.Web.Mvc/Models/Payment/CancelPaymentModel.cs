using AspZeroDemo.AbpZeroDemo.MultiTenancy.Payments;

namespace AspZeroDemo.AbpZeroDemo.Web.Models.Payment
{
    public class CancelPaymentModel
    {
        public string PaymentId { get; set; }

        public SubscriptionPaymentGatewayType Gateway { get; set; }
    }
}