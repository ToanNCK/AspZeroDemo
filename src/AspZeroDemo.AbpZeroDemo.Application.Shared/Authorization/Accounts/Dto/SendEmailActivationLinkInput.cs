using System.ComponentModel.DataAnnotations;

namespace AspZeroDemo.AbpZeroDemo.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}