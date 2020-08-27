using Abp.Application.Navigation;

namespace AspZeroDemo.AbpZeroDemo.Web.Areas.AppZeroDemo.Models.Layout
{
    public class MenuViewModel
    {
        public UserMenu Menu { get; set; }

        public string CurrentPageName { get; set; }
    }
}