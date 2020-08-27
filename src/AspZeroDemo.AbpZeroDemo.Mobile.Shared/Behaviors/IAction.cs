using Xamarin.Forms.Internals;

namespace AspZeroDemo.AbpZeroDemo.Behaviors
{
    [Preserve(AllMembers = true)]
    public interface IAction
    {
        bool Execute(object sender, object parameter);
    }
}