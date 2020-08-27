using System.Threading.Tasks;
using AspZeroDemo.AbpZeroDemo.ApiClient.Models;

namespace AspZeroDemo.AbpZeroDemo.Services.Account
{
    public interface IAccountService
    {
        AbpAuthenticateModel AbpAuthenticateModel { get; set; }
        
        AbpAuthenticateResultModel AuthenticateResultModel { get; set; }
        
        Task LoginUserAsync();

        Task LogoutAsync();
    }
}
