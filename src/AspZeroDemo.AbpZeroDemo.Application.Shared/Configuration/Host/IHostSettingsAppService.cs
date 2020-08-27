using System.Threading.Tasks;
using Abp.Application.Services;
using AspZeroDemo.AbpZeroDemo.Configuration.Host.Dto;

namespace AspZeroDemo.AbpZeroDemo.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
