using System;
using AspZeroDemo.AbpZeroDemo.Core;
using AspZeroDemo.AbpZeroDemo.Core.Dependency;
using AspZeroDemo.AbpZeroDemo.Services.Permission;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AspZeroDemo.AbpZeroDemo.Extensions.MarkupExtensions
{
    [ContentProperty("Text")]
    public class HasPermissionExtension : IMarkupExtension
    {
        public string Text { get; set; }
        
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (ApplicationBootstrapper.AbpBootstrapper == null || Text == null)
            {
                return false;
            }

            var permissionService = DependencyResolver.Resolve<IPermissionService>();
            return permissionService.HasPermission(Text);
        }
    }
}