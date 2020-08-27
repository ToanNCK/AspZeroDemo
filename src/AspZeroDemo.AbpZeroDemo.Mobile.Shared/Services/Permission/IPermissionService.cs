namespace AspZeroDemo.AbpZeroDemo.Services.Permission
{
    public interface IPermissionService
    {
        bool HasPermission(string key);
    }
}