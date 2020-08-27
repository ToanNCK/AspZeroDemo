using Microsoft.AspNetCore.Mvc;
using AspZeroDemo.AbpZeroDemo.Web.Controllers;

namespace AspZeroDemo.AbpZeroDemo.Web.Public.Controllers
{
    public class HomeController : AbpZeroDemoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}