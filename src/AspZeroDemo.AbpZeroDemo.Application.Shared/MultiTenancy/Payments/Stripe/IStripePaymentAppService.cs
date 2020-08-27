using System.Threading.Tasks;
using Abp.Application.Services;
using AspZeroDemo.AbpZeroDemo.MultiTenancy.Payments.Dto;
using AspZeroDemo.AbpZeroDemo.MultiTenancy.Payments.Stripe.Dto;

namespace AspZeroDemo.AbpZeroDemo.MultiTenancy.Payments.Stripe
{
    public interface IStripePaymentAppService : IApplicationService
    {
        Task ConfirmPayment(StripeConfirmPaymentInput input);

        StripeConfigurationDto GetConfiguration();

        Task<SubscriptionPaymentDto> GetPaymentAsync(StripeGetPaymentInput input);

        Task<string> CreatePaymentSession(StripeCreatePaymentSessionInput input);
    }
}