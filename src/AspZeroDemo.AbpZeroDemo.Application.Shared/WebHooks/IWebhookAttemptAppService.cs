using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using AspZeroDemo.AbpZeroDemo.WebHooks.Dto;

namespace AspZeroDemo.AbpZeroDemo.WebHooks
{
    public interface IWebhookAttemptAppService
    {
        Task<PagedResultDto<GetAllSendAttemptsOutput>> GetAllSendAttempts(GetAllSendAttemptsInput input);

        Task<ListResultDto<GetAllSendAttemptsOfWebhookEventOutput>> GetAllSendAttemptsOfWebhookEvent(GetAllSendAttemptsOfWebhookEventInput input);
    }
}
