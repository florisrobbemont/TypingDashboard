using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace TypingDashboard.Localization
{
    public static class TypingDashboardLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(TypingDashboardConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(TypingDashboardLocalizationConfigurer).GetAssembly(),
                        "TypingDashboard.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
