using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspZeroDemo.AbpZeroDemo.Web.Areas.AppZeroDemo.Models.Layout;
using AspZeroDemo.AbpZeroDemo.Web.Views;

namespace AspZeroDemo.AbpZeroDemo.Web.Areas.AppZeroDemo.Views.Shared.Components.AppZeroDemoRecentNotifications
{
    public class AppZeroDemoRecentNotificationsViewComponent : AbpZeroDemoViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(string cssClass)
        {
            var model = new RecentNotificationsViewModel
            {
                CssClass = cssClass
            };
            
            return Task.FromResult<IViewComponentResult>(View(model));
        }
    }
}
