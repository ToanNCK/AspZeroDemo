using System.Threading.Tasks;
using AspZeroDemo.AbpZeroDemo.Views;
using Xamarin.Forms;

namespace AspZeroDemo.AbpZeroDemo.Services.Modal
{
    public interface IModalService
    {
        Task ShowModalAsync(Page page);

        Task ShowModalAsync<TView>(object navigationParameter) where TView : IXamarinView;

        Task<Page> CloseModalAsync();
    }
}
