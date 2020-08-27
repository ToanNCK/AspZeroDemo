using AspZeroDemo.AbpZeroDemo.Editions.Dto;

namespace AspZeroDemo.AbpZeroDemo.MultiTenancy.Payments.Dto
{
    public class PaymentInfoDto
    {
        public EditionSelectDto Edition { get; set; }

        public decimal AdditionalPrice { get; set; }

        public bool IsLessThanMinimumUpgradePaymentAmount()
        {
            return AdditionalPrice < AbpZeroDemoConsts.MinimumUpgradePaymentAmount;
        }
    }
}
