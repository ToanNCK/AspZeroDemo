using System.Threading.Tasks;
using AspZeroDemo.AbpZeroDemo.Sessions.Dto;

namespace AspZeroDemo.AbpZeroDemo.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
