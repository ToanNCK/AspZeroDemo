using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using AspZeroDemo.AbpZeroDemo.MultiTenancy.Accounting.Dto;

namespace AspZeroDemo.AbpZeroDemo.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
