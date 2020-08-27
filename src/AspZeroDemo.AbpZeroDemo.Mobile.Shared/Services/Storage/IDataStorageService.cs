using System.Threading.Tasks;
using AspZeroDemo.AbpZeroDemo.ApiClient;
using AspZeroDemo.AbpZeroDemo.ApiClient.Models;
using AspZeroDemo.AbpZeroDemo.Sessions.Dto;

namespace AspZeroDemo.AbpZeroDemo.Services.Storage
{
    public interface IDataStorageService
    {
        Task StoreAccessTokenAsync(string newAccessToken);

        Task StoreAuthenticateResultAsync(AbpAuthenticateResultModel authenticateResultModel);

        AbpAuthenticateResultModel RetrieveAuthenticateResult();

        TenantInformation RetrieveTenantInfo();

        GetCurrentLoginInformationsOutput RetrieveLoginInfo();

        void ClearSessionPersistance();

        Task StoreLoginInformationAsync(GetCurrentLoginInformationsOutput loginInfo);

        Task StoreTenantInfoAsync(TenantInformation tenantInfo);
    }
}
