using System.Collections.Generic;
using Abp.Localization;
using AspZeroDemo.AbpZeroDemo.Install.Dto;

namespace AspZeroDemo.AbpZeroDemo.Web.Models.Install
{
    public class InstallViewModel
    {
        public List<ApplicationLanguage> Languages { get; set; }

        public AppSettingsJsonDto AppSettingsJson { get; set; }
    }
}
