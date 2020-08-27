using System.Collections.Generic;
using Abp.Localization;

namespace AspZeroDemo.AbpZeroDemo.Web.Areas.AppZeroDemo.Models.Layout
{
    public class LanguageSwitchViewModel
    {
        public IReadOnlyList<LanguageInfo> Languages { get; set; }

        public LanguageInfo CurrentLanguage { get; set; }
        
        public string CssClass { get; set; }
    }
}
