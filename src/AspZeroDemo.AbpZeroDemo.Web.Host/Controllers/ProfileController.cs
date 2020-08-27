using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Authorization;
using AspZeroDemo.AbpZeroDemo.Authorization.Users.Profile;
using AspZeroDemo.AbpZeroDemo.Storage;

namespace AspZeroDemo.AbpZeroDemo.Web.Controllers
{
    [Authorize]
    public class ProfileController : ProfileControllerBase
    {
        public ProfileController(
            ITempFileCacheManager tempFileCacheManager,
            IProfileAppService profileAppService) :
            base(tempFileCacheManager, profileAppService)
        {
        }
    }
}