using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using AspZeroDemo.AbpZeroDemo.Editions.Dto;
using AspZeroDemo.AbpZeroDemo.Web.Areas.AppZeroDemo.Models.Common;

namespace AspZeroDemo.AbpZeroDemo.Web.Areas.AppZeroDemo.Models.Editions
{
    [AutoMapFrom(typeof(GetEditionEditOutput))]
    public class EditEditionModalViewModel : GetEditionEditOutput, IFeatureEditViewModel
    {
        public bool IsEditMode => Edition.Id.HasValue;

        public IReadOnlyList<ComboboxItemDto> EditionItems { get; set; }

        public IReadOnlyList<ComboboxItemDto> FreeEditionItems { get; set; }
    }
}