using System.Threading.Tasks;
using Abp.Dependency;

namespace AspZeroDemo.AbpZeroDemo.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}