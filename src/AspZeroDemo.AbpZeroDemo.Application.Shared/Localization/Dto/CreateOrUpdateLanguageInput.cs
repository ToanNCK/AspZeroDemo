using System.ComponentModel.DataAnnotations;

namespace AspZeroDemo.AbpZeroDemo.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}