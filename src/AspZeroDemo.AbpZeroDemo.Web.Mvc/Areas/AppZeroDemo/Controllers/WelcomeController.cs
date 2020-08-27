using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using AspZeroDemo.AbpZeroDemo.Web.Controllers;

namespace AspZeroDemo.AbpZeroDemo.Web.Areas.AppZeroDemo.Controllers
{
    [Area("AppZeroDemo")]
    [AbpMvcAuthorize]
    public class WelcomeController : AbpZeroDemoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}