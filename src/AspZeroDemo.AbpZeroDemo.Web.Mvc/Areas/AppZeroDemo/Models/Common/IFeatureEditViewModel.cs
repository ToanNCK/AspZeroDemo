using System.Collections.Generic;
using Abp.Application.Services.Dto;
using AspZeroDemo.AbpZeroDemo.Editions.Dto;

namespace AspZeroDemo.AbpZeroDemo.Web.Areas.AppZeroDemo.Models.Common
{
    public interface IFeatureEditViewModel
    {
        List<NameValueDto> FeatureValues { get; set; }

        List<FlatFeatureDto> Features { get; set; }
    }
}