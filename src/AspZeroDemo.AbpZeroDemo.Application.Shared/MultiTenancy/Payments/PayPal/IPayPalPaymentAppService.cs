using System.Threading.Tasks;
using Abp.Application.Services;
using AspZeroDemo.AbpZeroDemo.MultiTenancy.Payments.PayPal.Dto;

namespace AspZeroDemo.AbpZeroDemo.MultiTenancy.Payments.PayPal
{
    public interface IPayPalPaymentAppService : IApplicationService
    {
        Task ConfirmPayment(long paymentId, string paypalOrderId);

        PayPalConfigurationDto GetConfiguration();
    }
}
