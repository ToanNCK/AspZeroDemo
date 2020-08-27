using AspZeroDemo.AbpZeroDemo.Models.Tenants;
using AspZeroDemo.AbpZeroDemo.ViewModels;
using Xamarin.Forms;

namespace AspZeroDemo.AbpZeroDemo.Views
{
    public partial class TenantsView : ContentPage, IXamarinView
    {
        public TenantsView()
        {
            InitializeComponent();
        }

        private async void ListView_OnItemAppearing(object sender, ItemVisibilityEventArgs e)
        {
            await ((TenantsViewModel)BindingContext).LoadMoreTenantsIfNeedsAsync(e.Item as TenantListModel);
        }
    }
}