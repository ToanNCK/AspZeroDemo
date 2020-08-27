using Abp.Application.Services;
using AspZeroDemo.AbpZeroDemo.Dto;
using AspZeroDemo.AbpZeroDemo.Logging.Dto;

namespace AspZeroDemo.AbpZeroDemo.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
