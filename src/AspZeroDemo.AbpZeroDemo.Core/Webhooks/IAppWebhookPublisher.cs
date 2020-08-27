using System.Threading.Tasks;
using AspZeroDemo.AbpZeroDemo.Authorization.Users;

namespace AspZeroDemo.AbpZeroDemo.WebHooks
{
    public interface IAppWebhookPublisher
    {
        Task PublishTestWebhook();
    }
}
