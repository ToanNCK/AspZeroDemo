using System.Threading.Tasks;

namespace AspZeroDemo.AbpZeroDemo.Security
{
    public interface IPasswordComplexitySettingStore
    {
        Task<PasswordComplexitySetting> GetSettingsAsync();
    }
}
