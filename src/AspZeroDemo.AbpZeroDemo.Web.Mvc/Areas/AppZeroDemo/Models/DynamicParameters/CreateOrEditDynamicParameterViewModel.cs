using System.Collections.Generic;
using AspZeroDemo.AbpZeroDemo.DynamicEntityParameters.Dto;

namespace AspZeroDemo.AbpZeroDemo.Web.Areas.AppZeroDemo.Models.DynamicParameters
{
    public class CreateOrEditDynamicParameterViewModel
    {
        public DynamicParameterDto DynamicParameterDto { get; set; }

        public List<string> AllowedInputTypes { get; set; }
    }
}
