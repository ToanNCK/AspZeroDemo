using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using AspZeroDemo.AbpZeroDemo.DynamicEntityParameters.Dto;
using AspZeroDemo.AbpZeroDemo.EntityDynamicParameterValues.Dto;

namespace AspZeroDemo.AbpZeroDemo.DynamicEntityParameters
{
    public interface IEntityDynamicParameterValueAppService
    {
        Task<EntityDynamicParameterValueDto> Get(int id);

        Task<ListResultDto<EntityDynamicParameterValueDto>> GetAll(GetAllInput input);

        Task Add(EntityDynamicParameterValueDto input);

        Task Update(EntityDynamicParameterValueDto input);

        Task Delete(int id);

        Task<GetAllEntityDynamicParameterValuesOutput> GetAllEntityDynamicParameterValues(GetAllEntityDynamicParameterValuesInput input);
    }
}
