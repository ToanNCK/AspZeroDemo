using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace AspZeroDemo.AbpZeroDemo.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
