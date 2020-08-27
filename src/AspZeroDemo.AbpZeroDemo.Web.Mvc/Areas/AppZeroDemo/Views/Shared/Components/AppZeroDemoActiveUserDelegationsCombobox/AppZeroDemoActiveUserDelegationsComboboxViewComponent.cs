using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspZeroDemo.AbpZeroDemo.Authorization.Delegation;
using AspZeroDemo.AbpZeroDemo.Authorization.Users.Delegation;
using AspZeroDemo.AbpZeroDemo.Web.Areas.AppZeroDemo.Models.Layout;
using AspZeroDemo.AbpZeroDemo.Web.Views;

namespace AspZeroDemo.AbpZeroDemo.Web.Areas.AppZeroDemo.Views.Shared.Components.AppZeroDemoActiveUserDelegationsCombobox
{
    public class AppZeroDemoActiveUserDelegationsComboboxViewComponent : AbpZeroDemoViewComponent
    {
        private readonly IUserDelegationAppService _userDelegationAppService;
        private readonly IUserDelegationConfiguration _userDelegationConfiguration;

        public AppZeroDemoActiveUserDelegationsComboboxViewComponent(
            IUserDelegationAppService userDelegationAppService, 
            IUserDelegationConfiguration userDelegationConfiguration)
        {
            _userDelegationAppService = userDelegationAppService;
            _userDelegationConfiguration = userDelegationConfiguration;
        }

        public async Task<IViewComponentResult> InvokeAsync(string logoSkin = null, string logoClass = "")
        {
            var activeUserDelegations = await _userDelegationAppService.GetActiveUserDelegations();
            var model = new ActiveUserDelegationsComboboxViewModel
            {
                UserDelegations = activeUserDelegations,
                UserDelegationConfiguration = _userDelegationConfiguration
            };

            return View(model);
        }
    }
}
