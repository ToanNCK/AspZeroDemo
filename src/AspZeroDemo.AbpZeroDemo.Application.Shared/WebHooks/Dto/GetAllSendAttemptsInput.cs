using AspZeroDemo.AbpZeroDemo.Dto;

namespace AspZeroDemo.AbpZeroDemo.WebHooks.Dto
{
    public class GetAllSendAttemptsInput : PagedInputDto
    {
        public string SubscriptionId { get; set; }
    }
}
