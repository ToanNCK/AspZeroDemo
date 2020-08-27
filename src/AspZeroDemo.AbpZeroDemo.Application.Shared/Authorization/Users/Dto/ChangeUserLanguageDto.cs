using System.ComponentModel.DataAnnotations;

namespace AspZeroDemo.AbpZeroDemo.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
