using System.Collections.Generic;
using Abp.Application.Services.Dto;
using AspZeroDemo.AbpZeroDemo.Editions.Dto;

namespace AspZeroDemo.AbpZeroDemo.MultiTenancy.Dto
{
    public class GetTenantFeaturesEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}