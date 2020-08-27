using System.Threading.Tasks;
using Abp.Webhooks;

namespace AspZeroDemo.AbpZeroDemo.WebHooks
{
    public interface IWebhookEventAppService
    {
        Task<WebhookEvent> Get(string id);
    }
}
