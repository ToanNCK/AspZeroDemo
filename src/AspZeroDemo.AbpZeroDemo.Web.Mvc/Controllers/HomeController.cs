using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspZeroDemo.AbpZeroDemo.Identity;

namespace AspZeroDemo.AbpZeroDemo.Web.Controllers
{
    public class HomeController : AbpZeroDemoControllerBase
    {
        private readonly SignInManager _signInManager;

        public HomeController(SignInManager signInManager)
        {
            _signInManager = signInManager;
        }

        public async Task<IActionResult> Index(string redirect = "", bool forceNewRegistration = false)
        {
            if (forceNewRegistration)
            {
                await _signInManager.SignOutAsync();
            }

            if (redirect == "TenantRegistration")
            {
                return RedirectToAction("SelectEdition", "TenantRegistration");
            }

            return AbpSession.UserId.HasValue ?
                RedirectToAction("Index", "Home", new { area = "AppZeroDemo" }) :
                RedirectToAction("Login", "Account");
        }
    }
}