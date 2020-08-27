using System.Collections.Generic;
using AspZeroDemo.AbpZeroDemo.Authorization.Users.Dto;

namespace AspZeroDemo.AbpZeroDemo.Web.Areas.AppZeroDemo.Models.Users
{
    public class UserLoginAttemptModalViewModel
    {
        public List<UserLoginAttemptDto> LoginAttempts { get; set; }
    }
}