using Microsoft.AspNetCore.Antiforgery;

namespace AspZeroDemo.AbpZeroDemo.Web.Controllers
{
    public class AntiForgeryController : AbpZeroDemoControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
