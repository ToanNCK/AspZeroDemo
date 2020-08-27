using System.Collections.Generic;
using Abp.Application.Services.Dto;
using AspZeroDemo.AbpZeroDemo.Configuration.Host.Dto;
using AspZeroDemo.AbpZeroDemo.Editions.Dto;

namespace AspZeroDemo.AbpZeroDemo.Web.Areas.AppZeroDemo.Models.HostSettings
{
    public class HostSettingsViewModel
    {
        public HostSettingsEditDto Settings { get; set; }

        public List<SubscribableEditionComboboxItemDto> EditionItems { get; set; }

        public List<ComboboxItemDto> TimezoneItems { get; set; }

        public List<string> EnabledSocialLoginSettings { get; set; } = new List<string>();
    }
}