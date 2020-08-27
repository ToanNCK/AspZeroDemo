using System.Collections.Generic;
using AspZeroDemo.AbpZeroDemo.Authorization.Delegation;
using AspZeroDemo.AbpZeroDemo.Authorization.Users.Delegation.Dto;

namespace AspZeroDemo.AbpZeroDemo.Web.Areas.AppZeroDemo.Models.Layout
{
    public class ActiveUserDelegationsComboboxViewModel
    {
        public IUserDelegationConfiguration UserDelegationConfiguration { get; set; }
        
        public List<UserDelegationDto> UserDelegations { get; set; }
    }
}
