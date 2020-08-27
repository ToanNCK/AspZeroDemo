using System.Collections.Generic;

namespace AspZeroDemo.AbpZeroDemo.MultiTenancy.Payments
{
    public interface IPaymentGatewayStore
    {
        List<PaymentGatewayModel> GetActiveGateways();
    }
}
