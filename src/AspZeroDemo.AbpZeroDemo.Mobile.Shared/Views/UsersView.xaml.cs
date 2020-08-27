using AspZeroDemo.AbpZeroDemo.Models.Users;
using AspZeroDemo.AbpZeroDemo.ViewModels;
using Xamarin.Forms;

namespace AspZeroDemo.AbpZeroDemo.Views
{
    public partial class UsersView : ContentPage, IXamarinView
    {
        public UsersView()
        {
            InitializeComponent();
        }

        public async void ListView_OnItemAppearing(object sender, ItemVisibilityEventArgs e)
        {
            await ((UsersViewModel) BindingContext).LoadMoreUserIfNeedsAsync(e.Item as UserListModel);
        }
    }
}