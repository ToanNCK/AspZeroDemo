using System.ComponentModel;
using Abp.AutoMapper;
using AspZeroDemo.AbpZeroDemo.Authorization.Users.Dto;

namespace AspZeroDemo.AbpZeroDemo.Models.Users
{
    [AutoMapFrom(typeof(CreateOrUpdateUserInput))]
    public class UserCreateOrUpdateModel : CreateOrUpdateUserInput, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}