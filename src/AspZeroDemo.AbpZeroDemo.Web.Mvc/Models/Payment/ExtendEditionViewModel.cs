using System.Collections.Generic;
using AspZeroDemo.AbpZeroDemo.Editions.Dto;
using AspZeroDemo.AbpZeroDemo.MultiTenancy.Payments;

namespace AspZeroDemo.AbpZeroDemo.Web.Models.Payment
{
    public class ExtendEditionViewModel
    {
        public EditionSelectDto Edition { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}