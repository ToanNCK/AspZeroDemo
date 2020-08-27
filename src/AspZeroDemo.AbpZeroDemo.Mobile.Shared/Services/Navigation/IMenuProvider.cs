using System.Collections.Generic;
using MvvmHelpers;
using AspZeroDemo.AbpZeroDemo.Models.NavigationMenu;

namespace AspZeroDemo.AbpZeroDemo.Services.Navigation
{
    public interface IMenuProvider
    {
        ObservableRangeCollection<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}