using System.Threading.Tasks;
using Abp.Application.Services;
using AspZeroDemo.AbpZeroDemo.Sessions.Dto;

namespace AspZeroDemo.AbpZeroDemo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
