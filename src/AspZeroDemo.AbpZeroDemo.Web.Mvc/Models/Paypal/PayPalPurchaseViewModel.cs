using AspZeroDemo.AbpZeroDemo.MultiTenancy.Payments.Paypal;

namespace AspZeroDemo.AbpZeroDemo.Web.Models.Paypal
{
    public class PayPalPurchaseViewModel
    {
        public long PaymentId { get; set; }

        public string Description { get; set; }

        public decimal Amount { get; set; }

        public PayPalPaymentGatewayConfiguration Configuration { get; set; }
    }
}
