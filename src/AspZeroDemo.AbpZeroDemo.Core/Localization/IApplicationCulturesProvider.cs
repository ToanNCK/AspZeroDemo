using System.Globalization;

namespace AspZeroDemo.AbpZeroDemo.Localization
{
    public interface IApplicationCulturesProvider
    {
        CultureInfo[] GetAllCultures();
    }
}