namespace AspZeroDemo.AbpZeroDemo.Configuration
{
    public interface IAppConfigurationWriter
    {
        void Write(string key, string value);
    }
}
