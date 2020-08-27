using System.Reflection;
using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace AspZeroDemo.AbpZeroDemo.Localization
{
    public static class AbpZeroDemoLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(
                    AbpZeroDemoConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(AbpZeroDemoLocalizationConfigurer).GetAssembly(),
                        "AspZeroDemo.AbpZeroDemo.Localization.AbpZeroDemo"
                    )
                )
            );
        }
    }
}