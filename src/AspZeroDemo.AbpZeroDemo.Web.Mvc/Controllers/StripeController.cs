using System;
using System.Threading.Tasks;
using Abp.Extensions;
using Microsoft.AspNetCore.Mvc;
using AspZeroDemo.AbpZeroDemo.Editions;
using AspZeroDemo.AbpZeroDemo.MultiTenancy.Payments;
using AspZeroDemo.AbpZeroDemo.MultiTenancy.Payments.Stripe;
using AspZeroDemo.AbpZeroDemo.MultiTenancy.Payments.Stripe.Dto;
using AspZeroDemo.AbpZeroDemo.Url;
using AspZeroDemo.AbpZeroDemo.Web.Models.Stripe;

namespace AspZeroDemo.AbpZeroDemo.Web.Controllers
{
    public class StripeController : StripeControllerBase
    {
        private readonly StripePaymentGatewayConfiguration _stripeConfiguration;
        private readonly IPaymentAppService _paymentAppService;
        private readonly IWebUrlService _webUrlService;

        public StripeController(
            StripeGatewayManager stripeGatewayManager,
            StripePaymentGatewayConfiguration stripeConfiguration,
            IStripePaymentAppService stripePaymentAppService,
            IPaymentAppService paymentAppService,
            IWebUrlService webUrlService)
            : base(stripeGatewayManager, stripeConfiguration, stripePaymentAppService)
        {
            _stripeConfiguration = stripeConfiguration;
            _paymentAppService = paymentAppService;
            _webUrlService = webUrlService;
        }

        public async Task<ActionResult> Purchase(long paymentId)
        {
            var payment = await _paymentAppService.GetPaymentAsync(paymentId);
            if (payment.Status != SubscriptionPaymentStatus.NotPaid)
            {
                throw new ApplicationException("This payment is processed before");
            }

            var model = new StripePurchaseViewModel
            {
                PaymentId = payment.Id,
                Amount = payment.Amount,
                Description = payment.Description,
                IsRecurring = payment.IsRecurring,
                Configuration = _stripeConfiguration,
                UpdateSubscription = payment.EditionPaymentType == EditionPaymentType.Upgrade
            };

            var sessionId = await StripePaymentAppService.CreatePaymentSession(new StripeCreatePaymentSessionInput()
            {
                PaymentId = paymentId,
                SuccessUrl = _webUrlService.GetSiteRootAddress().EnsureEndsWith('/') + "Stripe/GetPaymentResult",
                CancelUrl = _webUrlService.GetSiteRootAddress().EnsureEndsWith('/') + "Stripe/PaymentCancel",
            });

            if (payment.IsRecurring && payment.EditionPaymentType == EditionPaymentType.Upgrade)
            {
                model.IsRecurring = false;
            }

            model.SessionId = sessionId;

            return View(model);
        }

        public IActionResult PaymentCancel()
        {
            return View();
        }

        public async Task<ActionResult> GetPaymentResult(string sessionId)
        {
            var payment = await StripePaymentAppService.GetPaymentAsync(
                new StripeGetPaymentInput
                {
                    StripeSessionId = sessionId
                });

            if (payment.TenantId != AbpSession.TenantId)
            {
                return new NotFoundResult();
            }

            ViewBag.PaymentId = payment.Id;
            return View();
        }
    }
}